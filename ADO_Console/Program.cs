using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Reflection;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Exam
{

    class Program
    {
        //Connection Oriented
        public static void ListDataSqlCmd()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Employee";
                cmd.Connection = con;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.Write(dr["EmpId"] + ". " + dr[1] + " " + dr[2] );
                    Console.WriteLine();
                }
                con.Close();
            }
        }

        public static void AddEmployeeSQLCmd()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Insert into Employee(FirstName, LastName, DeptId, Salary) values (@FirstName, @LastName, @DeptID, @Salary)";
                cmd.Parameters.AddWithValue("@FirstName", "FirstTest");
                cmd.Parameters.AddWithValue("@LastName", "LastTest");
                cmd.Parameters.AddWithValue("@DeptId", 1);
                cmd.Parameters.AddWithValue("@Salary", 2103.43);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Added new Employee");
                    ListDataSqlCmd();
                }
                else
                    Console.WriteLine("Fail to add new Employee");
            }
        }

        public static void UpdateEmployeeSQLCmd()
        {
            using(SqlConnection con =new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update employee set FirstName=@FirstName, LastName=@LastName where EmpId=@EmpId";
                cmd.Parameters.AddWithValue("@FirstName", "NewUpdateName");
                cmd.Parameters.AddWithValue("@LastName", "UpdatedLastName");
                cmd.Parameters.AddWithValue("@EmpId", 12);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Updated");
                    Console.Clear();
                    ListDataSqlCmd();
                }
                else {
                    Console.Clear();
                    Console.WriteLine("Error...");

                }
            }
        }

        public static void DeleteEmployeeSQLCmd()
        {
            using(SqlConnection con=new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Delete from Employee where EmpID=@EmpId";
                cmd.Parameters.AddWithValue("@EmpId", 12);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Deleted");
                    ListDataSqlCmd();
                }
                else
                    Console.WriteLine("Fail");
                con.Close();
            }
        }


        //Disconnected 
        public static void ListDataSqlAdapter()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "Select * from Employee";
                da.SelectCommand.Connection = con;
                DataSet ds = new DataSet();
                da.Fill(ds);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Console.WriteLine(dr["EmpId"] + ". " + dr["FirstName"] + " " + dr["LastName"]);
                }
            }
        }

        public static void AddEmpoyeeAdapterWithoutBuilder()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandText = "select * from Employee";
                DataSet ds = new DataSet();
                da.Fill(ds);
                SqlCommand InsertCommand = new SqlCommand();
                InsertCommand.Connection = con;
                InsertCommand.CommandText = "insert into Employee (FirstName, LastName, DeptId, Salary) values (@FirstName, @LastName, @DeptID, @Salary)";
                InsertCommand.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 150, "FirstName"));
                InsertCommand.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 150, "LastName"));
                InsertCommand.Parameters.Add(new SqlParameter("@DeptId", SqlDbType.Int, 0, "DeptId"));
                InsertCommand.Parameters.Add(new SqlParameter("@Salary", SqlDbType.Money, 0, "Salary"));
                da.InsertCommand = InsertCommand;
                DataRow dr = ds.Tables[0].NewRow();
                dr["FirstName"] = "Adapter";
                dr["LastName"] = "Without Builder";
                dr["DeptId"] = 1;
                dr["Salary"] = 123.56;
                ds.Tables[0].Rows.Add(dr);
                da.Update(ds);
            }
        }

        public static void UpdateEmployeeAdapterWithoutBuilder()
        { 
            using(SqlConnection con =new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandText = "select * from Employee";
                DataSet ds = new DataSet();
                da.Fill(ds);
                SqlCommand updateCommand = new SqlCommand();
                updateCommand.Connection = con;
                updateCommand.CommandText = "update Employee set FirstName=@FirstName, LastName=@LastName where EmpId=@EmpId";
                updateCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar, 150, "FirstName");
                updateCommand.Parameters.Add("@LastNAme", SqlDbType.NVarChar, 150, "LastName");
                updateCommand.Parameters.Add("@EmpId", SqlDbType.Int, 0, "EmpId");
                da.UpdateCommand = updateCommand;
                ds.Tables[0].PrimaryKey = new DataColumn[] { ds.Tables[0].Columns["EmpId"] };
                ds.Tables[0].Rows.Find(14)["LastName"] = "Update Without Command Builder";
                da.Update(ds);
            }
        }

        public static void DeleteEmpWithoutCmdBuilder()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "Select * from Employee";
                da.SelectCommand.Connection = con;
                DataSet ds = new DataSet();
                da.Fill(ds);
                SqlCommand deleteCommand = new SqlCommand();
                deleteCommand.CommandText = "delete from Employee where EmpId=@EmpID";
                deleteCommand.Connection = con;
                deleteCommand.Parameters.Add("@EmpID", SqlDbType.Int, 0, "EmpId");
                da.DeleteCommand = deleteCommand;
                ds.Tables[0].PrimaryKey = new DataColumn[] { ds.Tables[0].Columns["EmpID"] };
                ds.Tables[0].Rows.Find(13).Delete();
                da.Update(ds);
            }
            
        }


        //With SqlCommandBuilder
        public static void AddEmployeeAdapterWithBuilder()
        { 
            using(SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "select * from Employee";
                da.SelectCommand.Connection = con;
                DataSet ds = new DataSet();
                da.Fill(ds);
                SqlCommandBuilder scb = new SqlCommandBuilder();
                scb.DataAdapter = da;
                DataRow dr = ds.Tables[0].NewRow();
                dr["FirstName"] = "Data Adapter";
                dr["LastName"] = "SqlCommandBuilder";
                dr["DeptId"] = 1;
                dr["Salary"] = 123.43;
                ds.Tables[0].Rows.Add(dr);
                da.Update(ds);
            }
        }

        public static void UpdateEmployeeWithBuilder()
        { 
            using(SqlConnection con =new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandText = "select * from Employee";
                DataSet ds = new DataSet();
                da.Fill(ds);
                SqlCommandBuilder scb = new SqlCommandBuilder();
                scb.DataAdapter = da;
                ds.Tables[0].PrimaryKey = new DataColumn[] { ds.Tables[0].Columns["EmpId"] };
                DataRow dr = ds.Tables[0].Rows.Find(16);
                dr["LastName"] = "Updated With Builder";
                da.Update(ds);
            }
        }

        public static void DeleteEmpWithBuilder()
        { 
            using(SqlConnection con=new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandText = "Select * from Employee";
                DataSet ds = new DataSet();
                da.Fill(ds);
                SqlCommandBuilder scb = new SqlCommandBuilder();
                scb.DataAdapter = da;
                ds.Tables[0].PrimaryKey = new DataColumn[] { ds.Tables[0].Columns["EmpId"] };
                ds.Tables[0].Rows.Find(15).Delete();
                da.Update(ds);
            }
        }
        
        static void Main(string[] args)
        {
            //ListDataSqlCmd();
            //ListDataSqlAdapter();
            //AddEmployeeSQLCmd();
            //UpdateEmployeeSQLCmd();
            //DeleteEmployeeSQLCmd();
            //AddEmpoyeeAdapterWithoutBuilder();
            //AddEmployeeAdapterWithBuilder();
            //UpdateEmployeeWithBuilder();
            //DeleteEmpWithBuilder();
            //UpdateEmployeeAdapterWithoutBuilder();
            DeleteEmpWithoutCmdBuilder();
            ListDataSqlAdapter();
            Console.ReadKey();
        }
    }
}
