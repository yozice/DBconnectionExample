using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_KW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonSave.Enabled = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSave.Enabled = false;
            try
            {
                string table = comboBoxTables.SelectedItem.ToString();
                if (table == "Контракты")
                {
                    dataGridViewDBTable.DataSource = SQL_DB.SelectFromTable("Select * from Contract");
                }
                else if (table == "Руководители")
                {
                    dataGridViewDBTable.DataSource = SQL_DB.SelectFromTable("Select * from Ruk");
                }
                else if (table == "Вспомогательный персонал")
                {
                    dataGridViewDBTable.DataSource = SQL_DB.SelectFromTable("Select * from VspomPers");
                }
                else if (table == "ППС")
                {
                    dataGridViewDBTable.DataSource = SQL_DB.SelectFromTable("Select * from PPS");
                    buttonSave.Enabled = true;
                }
                else if (table == "Дисциплины")
                {
                    dataGridViewDBTable.DataSource = SQL_DB.SelectFromTable("Select * from Dscp");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии БД", "Информация", MessageBoxButtons.OK);
            }
        }

        private void buttonAddRuk_Click(object sender, EventArgs e)
        {
            FormAdd addRukForm = new FormAdd();
            addRukForm.ShowDialog();
            if (!addRukForm.isCancel)
            {
                SQL_DB.AddRuk();
            }
        }
        private void dataGridViewDBTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //BindingSource bs = (BindingSource)dataGridViewDBTable.DataSource; // Se convierte el DataSource 
            //DataTable tCxC = (DataTable)bs.DataSource;
            SQL_DB.ModifyDB(dataGridViewDBTable.DataSource as DataTable);
        }

        private void buttonAddVP_Click(object sender, EventArgs e)
        {
            FormAdd addVPForm = new FormAdd();
            addVPForm.ShowDialog();
            if (!addVPForm.isCancel)
            {
                SQL_DB.AddVP();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddPPS_Click(object sender, EventArgs e)
        {
            FormAddPPS addPPSForm = new FormAddPPS();
            addPPSForm.ShowDialog();
            if (!addPPSForm.isCancel)
            {
                SQL_DB.AddPPS();
            }
        }

        private void buttonSelPPS_Click(object sender, EventArgs e)
        {
            dataGridViewDBTable.DataSource = SQL_DB.SelPPS();
        }

        private void buttonAddDscp_Click(object sender, EventArgs e)
        {
            FormAddDscp addDscpForm = new FormAddDscp();
            addDscpForm.ShowDialog();
            if(!addDscpForm.isCancel)
            {
                SQL_DB.AddDscp();
            }
        }

        private void buttonShowOld_Click(object sender, EventArgs e)
        {
            dataGridViewDBTable.DataSource = SQL_DB.SelAge(">");
        }

        private void buttonShowYoung_Click(object sender, EventArgs e)
        {
            dataGridViewDBTable.DataSource = SQL_DB.SelAge("<=");
        }

        private void buttonShowCand_Click(object sender, EventArgs e)
        {
            dataGridViewDBTable.DataSource = SQL_DB.SelDegree("'Кандидат'");
        }

        private void buttonShowDoct_Click(object sender, EventArgs e)
        {
            dataGridViewDBTable.DataSource = SQL_DB.SelDegree("'Доктор'");
        }
    }
}
