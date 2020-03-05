using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Odbc;


namespace AutomationOfPayrollCalculations
{
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }
        int a = 0, b = 15, s = 0, d = 15;
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string loginUser = textBoxLogin.Text;
                string passUser = textBoxPass.Text;
                ClassIniDataBase db = new ClassIniDataBase();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand commandagent = new SqlCommand(@"SELECT * FROM [User] WHERE Login = @uL AND Password = @uP AND Role= 'manager'", db.GetConnection());
                commandagent.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                commandagent.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
                adapter.SelectCommand = commandagent;
                adapter.Fill(table);
                DataTable table1 = new DataTable();
                SqlDataAdapter adapter1 = new SqlDataAdapter();
                SqlCommand commandclient = new SqlCommand(@"SELECT * FROM [User] WHERE Login = @uL AND Password = @uP AND Role = 'executor'", db.GetConnection());
                commandclient.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                commandclient.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
                adapter1.SelectCommand = commandclient;
                adapter1.Fill(table1);

                if (table.Rows.Count > 0)
                {
                    Form ifrm = new FormManager();
                    ifrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
                    ifrm.Top = this.Top;  // задаём открываемой форме позицию сверху равную позиции текущей формы
                    ifrm.Show();// отображаем Form2
                    this.Hide(); // скрываем Form1 (this - текущая форма)
                }
                else
                {
                    if (table1.Rows.Count > 0)

                    {

                        Form efrm = new FormExecutor();
                        efrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
                        efrm.Top = this.Top;  // задаём открываемой форме позицию сверху равную позиции текущей формы
                        efrm.Show();// отображаем Form2
                        this.Hide(); // скрываем Form1 (this - текущая форма)

                    }
                    else
                    {
                        MessageBox.Show("Не верный логин или пароль");
                        textBoxLogin.Clear();
                        textBoxPass.Clear();
                        a++;
                        if (a == 3)
                        {
                            a = 0;
                            timer1.Enabled = true;
                            button1.Enabled = false;
                            label4.Visible = true;
                            button2.Enabled = false;
                            textBoxLogin.Enabled = false;
                            textBoxPass.Enabled = false;

                        }
                    }
                }
            }
            finally { }
        }
        private void butExit_Click(object sender, EventArgs e)
        {

        }

        private void FormAutorization_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                if (b > 0)
                {
                    b--;
                    label4.Text = ("Вы заблокированы. Пожалуйста подождите: " + b);
                    if (b == 0)
                    {
                        b = d;
                        d += 5;
                        timer1.Enabled = false;
                        button1.Enabled = true;
                        label4.Visible = false;
                        button2.Enabled = true;
                        label4.Text = "";
                        textBoxLogin.Enabled = true;
                        textBoxPass.Enabled = true;
                    }
                }
                s++;
            }
        }
    }


