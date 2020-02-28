namespace DB_KW
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.dataGridViewDBTable = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAddVP = new System.Windows.Forms.Button();
            this.buttonAddPPS = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSelPPS = new System.Windows.Forms.Button();
            this.buttonAddDscp = new System.Windows.Forms.Button();
            this.buttonShowYoung = new System.Windows.Forms.Button();
            this.buttonShowOld = new System.Windows.Forms.Button();
            this.buttonShowCand = new System.Windows.Forms.Button();
            this.buttonShowDoct = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.CloseToolStripMenuItem.Text = "Выход";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgramToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.HelpToolStripMenuItem.Text = "Помощь";
            // 
            // AboutProgramToolStripMenuItem
            // 
            this.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            this.AboutProgramToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.AboutProgramToolStripMenuItem.Text = "О программе";
            this.AboutProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите таблицу";
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(729, 44);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(122, 40);
            this.buttonAddUser.TabIndex = 2;
            this.buttonAddUser.Text = "Добавить руководителя";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddRuk_Click);
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Items.AddRange(new object[] {
            "Контракты",
            "Руководители",
            "Вспомогательный персонал",
            "ППС",
            "Дисциплины"});
            this.comboBoxTables.Location = new System.Drawing.Point(289, 19);
            this.comboBoxTables.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(157, 21);
            this.comboBoxTables.TabIndex = 3;
            this.comboBoxTables.SelectedIndexChanged += new System.EventHandler(this.comboBoxTables_SelectedIndexChanged);
            // 
            // dataGridViewDBTable
            // 
            this.dataGridViewDBTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDBTable.Location = new System.Drawing.Point(169, 44);
            this.dataGridViewDBTable.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDBTable.Name = "dataGridViewDBTable";
            this.dataGridViewDBTable.RowTemplate.Height = 28;
            this.dataGridViewDBTable.Size = new System.Drawing.Size(541, 328);
            this.dataGridViewDBTable.TabIndex = 6;
            this.dataGridViewDBTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDBTable_CellContentClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(639, 376);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(71, 24);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAddVP
            // 
            this.buttonAddVP.Location = new System.Drawing.Point(729, 88);
            this.buttonAddVP.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddVP.Name = "buttonAddVP";
            this.buttonAddVP.Size = new System.Drawing.Size(122, 50);
            this.buttonAddVP.TabIndex = 12;
            this.buttonAddVP.Text = "Добавить вспомогательный персонал";
            this.buttonAddVP.UseVisualStyleBackColor = true;
            this.buttonAddVP.Click += new System.EventHandler(this.buttonAddVP_Click);
            // 
            // buttonAddPPS
            // 
            this.buttonAddPPS.Location = new System.Drawing.Point(729, 142);
            this.buttonAddPPS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddPPS.Name = "buttonAddPPS";
            this.buttonAddPPS.Size = new System.Drawing.Size(122, 40);
            this.buttonAddPPS.TabIndex = 13;
            this.buttonAddPPS.Text = "Добавить ППС";
            this.buttonAddPPS.UseVisualStyleBackColor = true;
            this.buttonAddPPS.Click += new System.EventHandler(this.buttonAddPPS_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(729, 232);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(121, 40);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Внести изменения в БД";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSelPPS
            // 
            this.buttonSelPPS.Location = new System.Drawing.Point(12, 44);
            this.buttonSelPPS.Name = "buttonSelPPS";
            this.buttonSelPPS.Size = new System.Drawing.Size(139, 64);
            this.buttonSelPPS.TabIndex = 15;
            this.buttonSelPPS.Text = "Формирование списка ППС, у которых истекает срок договора в этом учебном году";
            this.buttonSelPPS.UseVisualStyleBackColor = true;
            this.buttonSelPPS.Click += new System.EventHandler(this.buttonSelPPS_Click);
            // 
            // buttonAddDscp
            // 
            this.buttonAddDscp.Location = new System.Drawing.Point(12, 115);
            this.buttonAddDscp.Name = "buttonAddDscp";
            this.buttonAddDscp.Size = new System.Drawing.Size(139, 41);
            this.buttonAddDscp.TabIndex = 16;
            this.buttonAddDscp.Text = "Добавление дисциплин преподавателя";
            this.buttonAddDscp.UseVisualStyleBackColor = true;
            this.buttonAddDscp.Click += new System.EventHandler(this.buttonAddDscp_Click);
            // 
            // buttonShowYoung
            // 
            this.buttonShowYoung.Location = new System.Drawing.Point(12, 162);
            this.buttonShowYoung.Name = "buttonShowYoung";
            this.buttonShowYoung.Size = new System.Drawing.Size(139, 46);
            this.buttonShowYoung.TabIndex = 17;
            this.buttonShowYoung.Text = "Показать молодых преподавателей";
            this.buttonShowYoung.UseVisualStyleBackColor = true;
            this.buttonShowYoung.Click += new System.EventHandler(this.buttonShowYoung_Click);
            // 
            // buttonShowOld
            // 
            this.buttonShowOld.Location = new System.Drawing.Point(12, 214);
            this.buttonShowOld.Name = "buttonShowOld";
            this.buttonShowOld.Size = new System.Drawing.Size(139, 46);
            this.buttonShowOld.TabIndex = 18;
            this.buttonShowOld.Text = "Показать возрастных преподавателей";
            this.buttonShowOld.UseVisualStyleBackColor = true;
            this.buttonShowOld.Click += new System.EventHandler(this.buttonShowOld_Click);
            // 
            // buttonShowCand
            // 
            this.buttonShowCand.Location = new System.Drawing.Point(12, 266);
            this.buttonShowCand.Name = "buttonShowCand";
            this.buttonShowCand.Size = new System.Drawing.Size(139, 41);
            this.buttonShowCand.TabIndex = 19;
            this.buttonShowCand.Text = "Покзать кандидатов наук";
            this.buttonShowCand.UseVisualStyleBackColor = true;
            this.buttonShowCand.Click += new System.EventHandler(this.buttonShowCand_Click);
            // 
            // buttonShowDoct
            // 
            this.buttonShowDoct.Location = new System.Drawing.Point(12, 313);
            this.buttonShowDoct.Name = "buttonShowDoct";
            this.buttonShowDoct.Size = new System.Drawing.Size(139, 41);
            this.buttonShowDoct.TabIndex = 20;
            this.buttonShowDoct.Text = "Показать докторов наук";
            this.buttonShowDoct.UseVisualStyleBackColor = true;
            this.buttonShowDoct.Click += new System.EventHandler(this.buttonShowDoct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 408);
            this.Controls.Add(this.buttonShowDoct);
            this.Controls.Add(this.buttonShowCand);
            this.Controls.Add(this.buttonShowOld);
            this.Controls.Add(this.buttonShowYoung);
            this.Controls.Add(this.buttonAddDscp);
            this.Controls.Add(this.buttonSelPPS);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAddPPS);
            this.Controls.Add(this.buttonAddVP);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridViewDBTable);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "База данных";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.DataGridView dataGridViewDBTable;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAddVP;
        private System.Windows.Forms.Button buttonAddPPS;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSelPPS;
        private System.Windows.Forms.Button buttonAddDscp;
        private System.Windows.Forms.Button buttonShowYoung;
        private System.Windows.Forms.Button buttonShowOld;
        private System.Windows.Forms.Button buttonShowCand;
        private System.Windows.Forms.Button buttonShowDoct;
    }
}

