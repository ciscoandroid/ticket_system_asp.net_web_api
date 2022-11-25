using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;


namespace titcket_system.Pages.Clients
{
    public class IndexModel : PageModel
    {
        public List<User_Info> ListUsers = new List<User_Info>();

        //access the database and read from the database table
        public void OnGet()
        {
            try 
            {
                string connectionString = "Data Source = DESKTOP - IJDNFK3\\MSSQLSERVER2014; Initial Catalog = ticket_system; Persist Security Info = True; User ID = SA; Password = Superpenis_8";
                /*@"Data Source=ATIQ;Initial Catalog=UserDB;Integrated Security=False;Persist Security Info=False;
                User ID = sa; Password = ******";
                */
                //string connectionString = @"Data Source=DESKTOP-IJDNFK3\MSSQLSERVER2014;Initial Catalog=ticket_system;Persist Security Info=True;User ID=SA;Password=Superpenis_8";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    String sql = "SELECT * FROM tbl_users_ticket";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                User_Info userInfo = new User_Info();

                                userInfo.user_id = "" + reader.GetInt32(0);
                                userInfo.fullname = reader.GetString(1);
                                userInfo.email = reader.GetString(2);
                                userInfo.address = reader.GetString(3);
                                userInfo.rd_id = reader.GetString(4);

                                userInfo.create_at = reader.GetDateTime(5).ToString();

                                ListUsers.Add(userInfo);
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ëxception: " + ex.ToString());
            }
        }

        public class User_Info
        {
            public string user_id;
            public string fullname;
            public string email;
            public string address;
            public string phones;
            public string rd_id;

            public string create_at;
        }
    }
}
