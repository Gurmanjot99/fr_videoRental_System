using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr_videoRental_System.Folder
{
    public  class DatabaseConnection
    {

        //global object of the class so thus we can use in different method 
        SqlConnection sql;
       
        SqlCommand cmd;
        
        SqlDataReader DataReader;


        //connection sring to create the connection between files 
        String location = "Data Source=DESKTOP-HKD1BEO\\SQLEXPRESS;Initial Catalog=VideoRental_Fr;Integrated Security=True";


        //this method is used to execute the sql query like insert delete update in the database tables
        public void SqlOperation(String query)
        {
            sql = new SqlConnection(location);
            sql.Open();
            cmd = new SqlCommand(query, sql);
            cmd.ExecuteNonQuery();
            sql.Close();
        }

        // this method is used to search the record from the data base and then pass the whole record to the query using where clause of the sql
        public DataTable searchOperation(String qry)
        {
            DataTable tbl = new DataTable();

            sql = new SqlConnection(location);

            sql.Open();

            cmd = new SqlCommand(qry, sql);

            DataReader = cmd.ExecuteReader();

            tbl.Load(DataReader);

            sql.Close();

            return tbl;
        }
    }
}

