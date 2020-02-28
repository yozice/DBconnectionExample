using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_KW
{
    public partial class FormAddDscp : Form
    {
        public static int idPPS;
        public static string dscp;
        public static string isTeaching;
        public bool isCancel;
        public FormAddDscp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            isTeaching = "д";
            isCancel = true;
        }

        private void FormAddDscp_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (GetData())
            {
                if (textBoxIDPPS.Text == "" || textBoxDscp.Text == "")
                {
                    if (MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.RetryCancel) == DialogResult.Cancel)
                    {
                        Close();
                    }
                }
                else
                {
                    isCancel = false;
                    Close();
                }
            }
        }
        private bool GetData()
        {
            dscp = textBoxDscp.Text;
            if(!radioButtonYes.Checked)
            {
                isTeaching = "н";
            }
            try
            {
                idPPS = Convert.ToInt32(textBoxIDPPS.Text);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Идентификатор должен быть целочисленным!");
                return false;
            }
        }
    }
}
