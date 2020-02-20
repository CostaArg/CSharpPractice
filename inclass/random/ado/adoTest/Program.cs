using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data db = new Data();
            //db.PrintDb();

            Console.WriteLine("Give model: ");
            string model = Console.ReadLine();

            Console.WriteLine("Give price: ");
            string inputPrice = Console.ReadLine();

            int? price = string.IsNullOrEmpty(inputPrice) ? (int?)null : Convert.ToInt32(inputPrice);

            //if (inputPrice is null)
            //{
            //    price = null;
            //}
            //else
            //{
            //    price = Convert.ToInt32(inputPrice);
            //}

            Console.WriteLine("Give inches: ");
            decimal inches = Convert.ToDecimal(Console.ReadLine());

            Services.InsertTablets(model, price, inches);

        }
    }

    class Data
    {
        public void PrintDb()
        {
            var tabList = Services.GetAllTablets(x => x.Price > 3000);
            var tabList2 = Services.GetAllTablets(x => x.Price == null).OrderBy(x => x.Inches);

            foreach (var item in tabList)
            {
                item.Output();
            }
        }
    }

    class Tablet
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int? Price { get; set; }
        public decimal Inches { get; set; }

        public Tablet(int id, string model, int? price, decimal inches)
        {
            Id = id;
            Model = model;
            Price = price;
            Inches = inches;
        }

        public void Output()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Inches: " + Inches);
        }

    }

    class Services
    {
        public static string conString = ConfigurationManager.ConnectionStrings["plaisioConnection"].ConnectionString;

        public static List<Tablet> GetAllTablets()
        {
            List<Tablet> tempTabs = new List<Tablet>();

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string querystring = "Select * from Tablet";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(querystring, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    int id = Convert.ToInt32(reader["id"]);
                    string model = reader["model"].ToString();
                    int? price = Convert.ToInt32(reader["price"]);
                    decimal inches = Convert.ToDecimal(reader["inches"]);

                    while (reader.Read())
                    {
                        Tablet tab = new Tablet(id, model, price, inches);
                        tempTabs.Add(tab);
                    }

                    Console.WriteLine("Database reading was successful!");
                }
            }

            catch (SqlException ex)
            {
                Console.WriteLine("Error in the database " + ex.Message);
            }
            finally
            {

            }

            return tempTabs;

        }

        public static List<Tablet> GetAllTablets(Func<Tablet, bool> conditioner)
        {
            List<Tablet> tempTabs = new List<Tablet>();

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string querystring = "Select * from Tablet";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(querystring, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    int id = Convert.ToInt32(reader["id"]);
                    string model = reader["model"].ToString();
                    int? price = Convert.ToInt32(reader["price"]);
                    decimal inches = Convert.ToDecimal(reader["inches"]);

                    while (reader.Read())
                    {
                        Tablet tab = new Tablet(id, model, price, inches);

                        if (conditioner(tab))
                            tempTabs.Add(tab);
                    }

                    Console.WriteLine("Database reading was successful!");
                }
            }

            catch (SqlException ex)
            {
                Console.WriteLine("Error in the database " + ex.Message);
            }
            finally
            {

            }

            return tempTabs;

        }

        public static void InsertTablets(string model, int? price, decimal inches)
        {

            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "INSERT INTO Tablets (model, price, inches) VALUES (@Model, @Price, @Inches)";
                SqlCommand cmd = new SqlCommand(query, con);

                int? empty = null;

                var timi = empty ?? (object)DBNull.Value;

                cmd.Parameters.AddWithValue("@Model", model);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Inches", inches);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Records Inserted Successfully");
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {
                    con.Close();
                    Console.ReadKey();
                }
            }
        }
    }
}