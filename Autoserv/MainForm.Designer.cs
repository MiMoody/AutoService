
namespace Autoserv
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.MainText = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.ClientTable = new System.Windows.Forms.DataGridView();
            this.BtnPreviosPage = new System.Windows.Forms.Button();
            this.BtnNextPage = new System.Windows.Forms.Button();
            this.PageLab = new System.Windows.Forms.Label();
            this.CmbPagesCount = new System.Windows.Forms.ComboBox();
            this.CmbGenderFilter = new System.Windows.Forms.ComboBox();
            this.PageFilterLab = new System.Windows.Forms.Label();
            this.GenderFilterLab = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainPanel.Controls.Add(this.GenderFilterLab);
            this.MainPanel.Controls.Add(this.PageFilterLab);
            this.MainPanel.Controls.Add(this.CmbGenderFilter);
            this.MainPanel.Controls.Add(this.CmbPagesCount);
            this.MainPanel.Controls.Add(this.PageLab);
            this.MainPanel.Controls.Add(this.BtnNextPage);
            this.MainPanel.Controls.Add(this.BtnPreviosPage);
            this.MainPanel.Controls.Add(this.ClientTable);
            this.MainPanel.Controls.Add(this.BottomPanel);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1088, 471);
            this.MainPanel.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.TopPanel.Controls.Add(this.BtnExit);
            this.TopPanel.Controls.Add(this.MainText);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1088, 54);
            this.TopPanel.TabIndex = 0;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 421);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1088, 50);
            this.BottomPanel.TabIndex = 1;
            // 
            // MainText
            // 
            this.MainText.AutoSize = true;
            this.MainText.Location = new System.Drawing.Point(12, 16);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(155, 22);
            this.MainText.TabIndex = 0;
            this.MainText.Text = "Список клиентов";
            // 
            // BtnExit
            // 
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(1043, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(33, 32);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ClientTable
            // 
            this.ClientTable.AllowUserToAddRows = false;
            this.ClientTable.AllowUserToDeleteRows = false;
            this.ClientTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientTable.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientTable.Location = new System.Drawing.Point(16, 98);
            this.ClientTable.Name = "ClientTable";
            this.ClientTable.ReadOnly = true;
            this.ClientTable.Size = new System.Drawing.Size(1050, 269);
            this.ClientTable.TabIndex = 2;
            // 
            // BtnPreviosPage
            // 
            this.BtnPreviosPage.Location = new System.Drawing.Point(16, 388);
            this.BtnPreviosPage.Name = "BtnPreviosPage";
            this.BtnPreviosPage.Size = new System.Drawing.Size(53, 27);
            this.BtnPreviosPage.TabIndex = 3;
            this.BtnPreviosPage.Text = "<<";
            this.BtnPreviosPage.UseVisualStyleBackColor = true;
            this.BtnPreviosPage.Click += new System.EventHandler(this.BtnPreviosPage_Click);
            // 
            // BtnNextPage
            // 
            this.BtnNextPage.Location = new System.Drawing.Point(75, 388);
            this.BtnNextPage.Name = "BtnNextPage";
            this.BtnNextPage.Size = new System.Drawing.Size(53, 27);
            this.BtnNextPage.TabIndex = 4;
            this.BtnNextPage.Text = ">>";
            this.BtnNextPage.UseVisualStyleBackColor = true;
            this.BtnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // PageLab
            // 
            this.PageLab.AutoSize = true;
            this.PageLab.Location = new System.Drawing.Point(146, 391);
            this.PageLab.Name = "PageLab";
            this.PageLab.Size = new System.Drawing.Size(32, 22);
            this.PageLab.TabIndex = 5;
            this.PageLab.Text = "10";
            // 
            // CmbPagesCount
            // 
            this.CmbPagesCount.AutoCompleteCustomSource.AddRange(new string[] {
            "10",
            "50",
            "200",
            "Все"});
            this.CmbPagesCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPagesCount.FormattingEnabled = true;
            this.CmbPagesCount.Items.AddRange(new object[] {
            "Все",
            "10",
            "30",
            "200"});
            this.CmbPagesCount.Location = new System.Drawing.Point(906, 61);
            this.CmbPagesCount.Margin = new System.Windows.Forms.Padding(4);
            this.CmbPagesCount.Name = "CmbPagesCount";
            this.CmbPagesCount.Size = new System.Drawing.Size(160, 30);
            this.CmbPagesCount.TabIndex = 11;
            this.CmbPagesCount.SelectedIndexChanged += new System.EventHandler(this.CmbPagesCount_SelectedIndexChanged);
            // 
            // CmbGenderFilter
            // 
            this.CmbGenderFilter.AutoCompleteCustomSource.AddRange(new string[] {
            "Все",
            "М",
            "Ж"});
            this.CmbGenderFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGenderFilter.FormattingEnabled = true;
            this.CmbGenderFilter.Items.AddRange(new object[] {
            "Все",
            "М",
            "Ж"});
            this.CmbGenderFilter.Location = new System.Drawing.Point(545, 61);
            this.CmbGenderFilter.Margin = new System.Windows.Forms.Padding(4);
            this.CmbGenderFilter.Name = "CmbGenderFilter";
            this.CmbGenderFilter.Size = new System.Drawing.Size(160, 30);
            this.CmbGenderFilter.TabIndex = 12;
            this.CmbGenderFilter.SelectedIndexChanged += new System.EventHandler(this.CmbGenderFilter_SelectedIndexChanged);
            // 
            // PageFilterLab
            // 
            this.PageFilterLab.AutoSize = true;
            this.PageFilterLab.Location = new System.Drawing.Point(712, 64);
            this.PageFilterLab.Name = "PageFilterLab";
            this.PageFilterLab.Size = new System.Drawing.Size(192, 22);
            this.PageFilterLab.TabIndex = 13;
            this.PageFilterLab.Text = "Количество страниц:";
            // 
            // GenderFilterLab
            // 
            this.GenderFilterLab.AutoSize = true;
            this.GenderFilterLab.Location = new System.Drawing.Point(385, 64);
            this.GenderFilterLab.Name = "GenderFilterLab";
            this.GenderFilterLab.Size = new System.Drawing.Size(158, 22);
            this.GenderFilterLab.TabIndex = 14;
            this.GenderFilterLab.Text = "Фильтер по полу:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 471);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Label MainText;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridView ClientTable;
        private System.Windows.Forms.Label PageLab;
        private System.Windows.Forms.Button BtnNextPage;
        private System.Windows.Forms.Button BtnPreviosPage;
        private System.Windows.Forms.ComboBox CmbPagesCount;
        private System.Windows.Forms.Label GenderFilterLab;
        private System.Windows.Forms.Label PageFilterLab;
        private System.Windows.Forms.ComboBox CmbGenderFilter;
    }
}

