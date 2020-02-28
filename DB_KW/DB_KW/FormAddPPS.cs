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
    public partial class FormAddPPS : Form
    {
        public static string name;
        public static string degree;
        public static string kaf;
        public static string dolzh;
        public static string sx;
        public static int age;
        public static DateTime dateEnd;
        public static string trudKn;

        public bool isCancel;
        public FormAddPPS()
        {
            InitializeComponent();
            comboBoxDay.Text = comboBoxDay.Items[0].ToString();
            comboBoxMonth.Text = comboBoxMonth.Items[0].ToString();
            comboBoxYear.Text = comboBoxYear.Items[0].ToString();
            comboBoxSx.Text = comboBoxSx.Items[0].ToString();
            this.StartPosition = FormStartPosition.CenterParent;
            isCancel = true;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FormAddPPS_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (GetData())
            {
                if (textBoxName.Text == "" || textBoxTrudKn.Text == "" || textBoxDegree.Text == "" || textBoxKaf.Text == ""
                    || textBoxDolzh.Text == "" || textBoxAge.Text == "")
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
            name = textBoxName.Text;
            degree = textBoxDegree.Text;
            kaf = textBoxKaf.Text;
            dolzh = textBoxDolzh.Text;
            sx = comboBoxSx.Text;
            if (!IsDigitsOnly(textBoxTrudKn.Text))
            {
                MessageBox.Show("Номер трудовой книги должен быть целочисленным!");
                return false;
            }
            trudKn = textBoxTrudKn.Text;
            try
            {
                dateEnd = new DateTime(Convert.ToInt32(comboBoxYear.Text), Convert.ToInt32(comboBoxMonth.Text), Convert.ToInt32(comboBoxDay.Text));
                age = Convert.ToInt32(textBoxAge.Text);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
