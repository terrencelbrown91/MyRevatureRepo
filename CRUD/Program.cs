using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "Data source = DESKTOP-8GSG83E\\SQLSERVER123;initial Catalog=Chinook; integrated security = true";
            SqlConnection con = new SqlConnection(str);
            string querystring = "Select * from Album";
            con.Open();
            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Album> ls = new List<Album>();
            Album a;

            while (dr.Read())
            {
                a = dr[0].ToString();
                a = dr[1].ToString();
                Console.WriteLine(dr[0].ToString());// + "" + dr[1].ToString() + "" + dr[2].ToString()); //+ "" + dr[4].ToString() + "" + dr[5].ToString());
                ls.Add(a);

            }

        }
    }
}
