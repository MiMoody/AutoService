using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoserv
{
    public partial class MainForm : Form
    {
        int TotalPages;
        int CurrentIndexPage = 1;
        int PageSize;
        AutoservEntities db = new AutoservEntities();

        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateTotalPages()
        {
            int RowCount = 0;
            if (CmbGenderFilter.SelectedIndex == 0)
                RowCount = Convert.ToInt32(db.Client.ToList().Count());
            else if (CmbGenderFilter.SelectedIndex == 1)
                RowCount = Convert.ToInt32(db.Client.ToList().Where(p => p.GenderCode == "м").Count());
            else if (CmbGenderFilter.SelectedIndex == 2)
                RowCount = Convert.ToInt32(db.Client.ToList().Where(p => p.GenderCode == "ж").Count());

            TotalPages = RowCount / PageSize;
            if (RowCount % PageSize > 0)
                TotalPages += 1;
        }

        public string PrintLabText(bool check, int page = 1)
        {
            int PreviousPageOffSet = (page - 1) * PageSize;
            if (check)
            {
                
                if (CmbGenderFilter.SelectedIndex == 0)
                {
                    var before = db.Client.Select(p => p.ID).Take(PreviousPageOffSet).Count();
                    var NoProviders = db.Client.Select(p => p.ID).Take(PreviousPageOffSet).ToArray();
                    var after = db.Client.Where(p => !NoProviders.Contains(p.ID)).Take(PageSize).Count();
                    return (before + after).ToString() + " из " + db.Client.Count().ToString();
                }
                else if (CmbGenderFilter.SelectedIndex == 1)
                {
                    var before = db.Client.Where(p => p.GenderCode == "м").Select(p => p.ID).Take(PreviousPageOffSet).Count();
                    var NoProviders = db.Client.Where(p => p.GenderCode == "м").Select(p => p.ID).Take(PreviousPageOffSet).ToArray();
                    var after = db.Client.Where(p => !NoProviders.Contains(p.ID) && p.GenderCode =="м").Take(PageSize).Count();
                    return (before + after).ToString() + " из " + db.Client.Where(p => p.GenderCode == "м").Count().ToString();
                }

                else if (CmbGenderFilter.SelectedIndex == 2)
                {
                    var before = db.Client.Where(p => p.GenderCode == "ж").Select(p => p.ID).Take(PreviousPageOffSet).Count();
                    var NoProviders = db.Client.Where(p => p.GenderCode == "ж").Select(p => p.ID).Take(PreviousPageOffSet).ToArray();
                    var after = db.Client.Where(p => !NoProviders.Contains(p.ID) && p.GenderCode == "ж").Take(PageSize).Count();
                    return (before + after).ToString() + " из " + db.Client.Where(p => p.GenderCode == "ж").Count().ToString();
                }

                return "";
            }
            else
            {
                if (CmbGenderFilter.SelectedIndex == 0)
                    return db.Client.OrderBy(p => p.ID).Take(PageSize).Count().ToString() + " из " + db.Client.Count().ToString();
                else if (CmbGenderFilter.SelectedIndex == 1)
                    return db.Client.OrderBy(p => p.ID).Where(p => p.GenderCode == "м").Take(PageSize).Count().ToString() + " из " + db.Client.Where(p => p.GenderCode == "м").Count().ToString();
                else if (CmbGenderFilter.SelectedIndex == 2)
                    return db.Client.OrderBy(p => p.ID).Where(p => p.GenderCode == "ж").Take(PageSize).Count().ToString() + " из " + db.Client.Where(p => p.GenderCode == "ж").Count().ToString();
                return "";
            }

                
        }
        private List<Client> GetCurrentRecords(int page)
        {
            List<Client> list = new List<Client>();

            if (page == 1)
            {
                if (CmbGenderFilter.SelectedIndex == 0)
                    list = db.Client.OrderBy(p => p.ID).Take(PageSize).ToList();
                else if (CmbGenderFilter.SelectedIndex == 1)
                    list = db.Client.OrderBy(p => p.ID).Where(p => p.GenderCode == "м").Take(PageSize).ToList();
                else if (CmbGenderFilter.SelectedIndex == 2)
                    list = db.Client.OrderBy(p => p.ID).Where(p => p.GenderCode == "ж").Take(PageSize).ToList();
                PageLab.Text = PrintLabText(false, page);
            }
            else
            {
                int PreviousPageOffSet = (page - 1) * PageSize;
                int[] NoProviders = null;
                if (CmbGenderFilter.SelectedIndex == 0)
                {
                    NoProviders = db.Client.Select(p => p.ID).Take(PreviousPageOffSet).ToArray();
                    list = db.Client.Where(p => !NoProviders.Contains(p.ID)).Take(PageSize).ToList();
                }
                else if (CmbGenderFilter.SelectedIndex == 1)
                {
                    NoProviders = db.Client.Where(p => p.GenderCode == "м").Select(p => p.ID).Take(PreviousPageOffSet).ToArray();
                    list = db.Client.Where(p => !NoProviders.Contains(p.ID) && p.GenderCode == "м").Take(PageSize).ToList();
                }
                    
                else if (CmbGenderFilter.SelectedIndex == 2)
                {
                    NoProviders = db.Client.Where(p => p.GenderCode == "ж").Select(p => p.ID).Take(PreviousPageOffSet).ToArray();
                    list = db.Client.Where(p => !NoProviders.Contains(p.ID) && p.GenderCode == "ж").Take(PageSize).ToList();
                }
                   
                PageLab.Text = PrintLabText(true, page);
            }

            return list;
        }

        public void UpdateTable()
        {
            if (CmbPagesCount.SelectedIndex == -1)
            CmbPagesCount.SelectedIndex = 0;
            if (CmbGenderFilter.SelectedIndex == -1)
            CmbGenderFilter.SelectedIndex = 0;
            List<Client> clients = new List<Client>();
            string check = null;
            if (CmbGenderFilter.SelectedIndex == 0) check = "Все";
            if (CmbGenderFilter.SelectedIndex == 1) check = "м";
            if (CmbGenderFilter.SelectedIndex == 2) check = "ж";
            foreach (Client client in db.Client.ToList())
            {
                if (client.GenderCode != check && check != "Все") continue;
                client.Quantity = db.ClientService.Where(p => p.ClientID == client.ID).Count();
                DateTime LastTime = DateTime.MinValue;
                foreach (ClientService clientService in db.ClientService.ToList())
                    if (clientService.StartTime > LastTime) LastTime = clientService.StartTime;
                client.LastDate = LastTime;
                foreach (TagOfClient tagOfClient in db.TagOfClient.ToList())
                    if (client.ID == tagOfClient.ClientID) client.Tags += tagOfClient.Tag.Title + ";";
                clients.Add(client);
            }
            PageSize = Convert.ToInt32(clients.Count());
            CalculateTotalPages();
            PageLab.Text = PrintLabText(false,1);
            ClientTable.DataSource = clients;
            ClientTable.Columns[9].Visible = false;
            ClientTable.Columns[13].Visible = false;
            ClientTable.Columns[14].Visible = false;
            ClientTable.Columns[15].Visible = false;
            ClientTable.Columns[0].HeaderText = "ID";
            ClientTable.Columns[1].HeaderText = "Имя";
            ClientTable.Columns[2].HeaderText = "Фамилия";
            ClientTable.Columns[3].HeaderText = "Отчество";
            ClientTable.Columns[4].HeaderText = "Дата рождения";
            ClientTable.Columns[5].HeaderText = "Дата добавления";
            ClientTable.Columns[6].HeaderText = "Email";
            ClientTable.Columns[7].HeaderText = "Телефон";
            ClientTable.Columns[8].HeaderText = "Пол";
            ClientTable.Columns[10].HeaderText = "Последнее посещение";
            ClientTable.Columns[11].HeaderText = "Количество посещений";
            ClientTable.Columns[12].HeaderText = "Список тегов";
        }

       

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void CmbPagesCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbPagesCount.SelectedIndex == 0) UpdateTable();
            else
            {
                PageSize = Convert.ToInt32(CmbPagesCount.SelectedItem);
                CalculateTotalPages();
                ClientTable.DataSource = GetCurrentRecords(1);

            }
        }

        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            if (CurrentIndexPage < TotalPages)
            {
                CurrentIndexPage++;
                ClientTable.DataSource =
                GetCurrentRecords(CurrentIndexPage);
            }
        }

        private void BtnPreviosPage_Click(object sender, EventArgs e)
        {
            if (CurrentIndexPage > 1)
            {
                CurrentIndexPage--;
                ClientTable.DataSource =
                GetCurrentRecords(CurrentIndexPage);
            }
        }

        private void CmbGenderFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbGenderFilter.SelectedIndex == 0 || CmbPagesCount.SelectedIndex == 0 ) UpdateTable();
            else
            {
                PageSize = Convert.ToInt32(CmbPagesCount.SelectedItem);
                CalculateTotalPages();
                ClientTable.DataSource = GetCurrentRecords(1);
            }
        }
    }
}
