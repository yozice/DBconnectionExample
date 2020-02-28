using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_KW
{
    class SQL_DB
    {
        const string datasource = @"Server=localhost\SQLEXPRESS;Database=KursProj;Trusted_Connection=True;";
        public static SqlConnection Connect() {
            SqlConnection connection = new SqlConnection(datasource);
            return connection;
        }

        public static DataTable SelectFromTable(string query)
        {
            SqlConnection connect = Connect();
            DataTable result = new DataTable();
            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand(@"set dateformat dmy " + query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connect.State != ConnectionState.Closed)
                    connect.Close();
            }
            return result;
        }

        public static void AddRuk()
        {
            int idContract = GetCountRows("Contract") + 1;
            int id_Rk = GetCountRows("Ruk") + 1;
            SqlConnection connect = Connect();
            string query1 = "SET IDENTITY_INSERT Contract ON " +
                "INSERT INTO Contract(ID_Contract, DateEnd, TK) VALUES (" +
                "'" + idContract +
                "' , '" + FormAdd.dateEnd.ToString() +
                "' , '" + FormAdd.trudKn + "'); " +
                "SET IDENTITY_INSERT Contract OFF; " +
                "SET IDENTITY_INSERT Ruk ON " +
                "INSERT INTO Ruk(ID_Rk, NameDir, ID_Contract) VALUES (" +
                "'" + id_Rk +
                "' , '" + FormAdd.name +
                "' , '" + idContract + "'); " + 
                "SET IDENTITY_INSERT Ruk OFF;";

            try
            {
                connect.Open();
                SqlCommand command1 = new SqlCommand(query1, connect);
                Int32 rowsAffected = command1.ExecuteNonQuery();
                MessageBox.Show("Было добавлено " + rowsAffected.ToString() + "строк.", "информация", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State != ConnectionState.Closed)
                    connect.Close();
            }
        }

        public static void AddVP()
        {
            int idContract = GetCountRows("Contract") + 1;
            int id_VP = GetCountRows("VspomPers") + 1;
            SqlConnection connect = Connect();
            string query1 = "SET IDENTITY_INSERT Contract ON " +
                "INSERT INTO Contract(ID_Contract, DateEnd, TK) VALUES (" +
                "'" + idContract +
                "' , '" + FormAdd.dateEnd.ToString() +
                "' , '" + FormAdd.trudKn + "'); " +
                "SET IDENTITY_INSERT Contract OFF; " +
                "SET IDENTITY_INSERT VspomPers ON " +
                "INSERT INTO VspomPers(ID_VP, NamePer, ID_Contract) VALUES (" +
                "'" + id_VP +
                "' , '" + FormAdd.name +
                "' , '" + idContract + "'); " +
                "SET IDENTITY_INSERT VspomPers OFF;";

            try
            {
                connect.Open();
                SqlCommand command1 = new SqlCommand(query1, connect);
                Int32 rowsAffected = command1.ExecuteNonQuery();
                MessageBox.Show("Было добавлено " + rowsAffected.ToString() + "строк.", "информация", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State != ConnectionState.Closed)
                    connect.Close();
            }
        }
        public static void AddPPS()
        {
            int idContract = GetCountRows("Contract") + 1;
            int id_PPS = GetCountRows("PPS") + 1;
            SqlConnection connect = Connect();
            string query1 = "SET IDENTITY_INSERT Contract ON " +
                "INSERT INTO Contract(ID_Contract, DateEnd, TK) VALUES (" +
                "'" + idContract +
                "' , '" + FormAddPPS.dateEnd.ToString() +
                "' , '" + FormAddPPS.trudKn + "'); " +
                "SET IDENTITY_INSERT Contract OFF; " +
                "SET IDENTITY_INSERT PPS ON " +
                "INSERT INTO PPS(ID_Tchr, NameTchr, Degree, Kafedra, Dolzh, Sx, Age, ID_Contract) VALUES (" +
                "'" + id_PPS +
                "' , '" + FormAddPPS.name +
                "' , '" + FormAddPPS.degree +
                "' , '" + FormAddPPS.kaf +
                "' , '" + FormAddPPS.dolzh +
                "' , '" + FormAddPPS.sx +
                "' , '" + FormAddPPS.age +
                "' , '" + idContract + "'); " +
                "SET IDENTITY_INSERT PPS OFF;";

            try
            {
                connect.Open();
                SqlCommand command1 = new SqlCommand(query1, connect);
                Int32 rowsAffected = command1.ExecuteNonQuery();
                MessageBox.Show("Было добавлено " + rowsAffected.ToString() + "строк.", "информация", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State != ConnectionState.Closed)
                    connect.Close();
            }
        }
        public static int GetCountRows(string tabl)
        {
            int count = 0;
            SqlConnection connect = Connect();
            DataTable result = new DataTable();
            string query = "SELECT Count(*) FROM " + tabl + ";";
            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
                count = Convert.ToInt32(result.Rows[0][0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State != ConnectionState.Closed)
                    connect.Close();
            }
            return count;
        }

        public static void ModifyDB(DataTable dataTable)
        {
            SqlConnection connect = Connect();
            string query = "SELECT * FROM PPS";
            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                adapter.Update(dataTable);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connect.State != ConnectionState.Closed)
                    connect.Close();
            }
        }
        public static DataTable SelPPS()
        {
            string query = "select * from PPS " +
                "inner join Contract " +
                "ON Contract.ID_Contract = PPS.ID_Contract " +
                "where Contract.DateEnd < '2020.08.01' " +
                "order by Kafedra";
            SqlConnection connect = Connect();
            DataTable result = new DataTable();
            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand(@"set dateformat dmy " + query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connect.State != ConnectionState.Closed)
                    connect.Close();
            }
            return result;
        }
        public static void AddDscp()
        {
            SqlConnection connect = Connect();
            string query1 = "" +
                "INSERT INTO Dscp(NameDscp, Actuality, ID_Tchr) VALUES (" +
                "'" + FormAddDscp.dscp +
                "' , '" + FormAddDscp.isTeaching +
                "' , '" + FormAddDscp.idPPS + "'); " +
                "";

            try
            {
                connect.Open();
                SqlCommand command1 = new SqlCommand(query1, connect);
                Int32 rowsAffected = command1.ExecuteNonQuery();
                MessageBox.Show("Было добавлено " + rowsAffected.ToString() + "строк.", "информация", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State != ConnectionState.Closed)
                    connect.Close();
            }
        }
        public static DataTable SelAge(string sign)
        {
            string query = "select * from PPS " +
                "where Age" + sign + "50;";
            SqlConnection connect = Connect();
            DataTable result = new DataTable();
            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand(@"set dateformat dmy " + query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connect.State != ConnectionState.Closed)
                    connect.Close();
            }
            return result;
        }
        public static DataTable SelDegree(string deg)
        {
            string query = "select * from PPS " +
                "where Degree = " + deg;
            SqlConnection connect = Connect();
            DataTable result = new DataTable();
            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand(@"set dateformat dmy " + query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connect.State != ConnectionState.Closed)
                    connect.Close();
            }
            return result;
        }
    }
}
