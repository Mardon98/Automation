using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//данный модуль необходимо подключить самостоятельно
using System.Data.Odbc; //данный модуль необходимо подключить самостоятельно

namespace AutomationOfPayrollCalculations
{
    class ClassIniDataBase
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-GUV9959\SQLEXPRESS;Initial Catalog=Automation of payroll calculations;Integrated Security=True"); //это строка подключения базы данных

        public void openConnection()

        {

            if (connection.State == System.Data.ConnectionState.Closed)

                connection.Open();
        }

        public void closeConnection()

        {
            if (connection.State == System.Data.ConnectionState.Open)

                connection.Close();
        }

        public SqlConnection GetConnection()
        {

            return connection;
        }

    }

}
    
