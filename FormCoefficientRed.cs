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
    public partial class FormCoefficientRed : Form
    {
        public FormCoefficientRed()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCoefficient f2 = new FormCoefficient();
            f2.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) //кнопка добавления записей в базу данных 
        {

            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-GUV9959\SQLEXPRESS;Initial Catalog=Automation of payroll calculations;Integrated Security=True");
                connection.Open();
                int id_Coefficient = int.Parse(textBoxIdCoefficient.Text);//эта строчка кода преобразует введенный ID коэффициент из строкового типа в тип int 
                int Junior = int.Parse(textBoxJunior.Text);
                int Middle = int.Parse(textBoxMiddle.Text);
                int Senior = int.Parse(textBoxSenior.Text);
                double K_A_P = Convert.ToDouble(textBoxK_A_P.Text);
                double K_U_O = Convert.ToDouble(textBoxK_U_O.Text);
                double K_T_O_C = Convert.ToDouble(textBoxK_T_O_C.Text);
                int K_V = int.Parse(textBoxK_V.Text);
                int K_C = int.Parse(textBoxK_C.Text);
                int K_P_D_E = int.Parse(textBoxK_P_D_E.Text);
                String querySave = "INSERT INTO Coefficient (id_Coefficient, Junior, Middle, Senior, K_A_P, K_U_O, K_T_O_C, K_V, K_C, K_P_D_E ) VALUES ('" + id_Coefficient + "','" + textBoxJunior.Text + "','" + textBoxMiddle.Text + "','" + textBoxSenior.Text + "','" + textBoxK_A_P.Text + "','" + textBoxK_U_O.Text + "', '" + textBoxK_T_O_C.Text + "','" + textBoxK_V.Text + "','" + textBoxK_C.Text + "','" + textBoxK_P_D_E.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(querySave, connection);
                // SDA.SelectCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Коэффициент добавлен в базу данных");
            }
        }
    }
}
