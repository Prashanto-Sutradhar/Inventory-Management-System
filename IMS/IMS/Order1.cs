using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace IMS
{
    class Order1
    {
        public string message;
        public string ProductName { get; set; }
        public string ProductID { get; set; }
        public string Price { get; set; }
        public string OrderDate { get; set; }
        public string ArrivalDate { get; set; }



        public DataTable Select()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=IMS;User ID=sa;Password=tiger");

            DataTable dt = new DataTable();

            string query = "Select * from order";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }


        public bool Insert(Order1 o)
        {


            bool isSuccess = false;



            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=IMS;User ID=sa;Password=tiger");
            try
            {



                string query = "Insert into order (productName,productID,price,orderDate,arrivalDate)values(@productName,@productID,@price,@orderDate,@arrivalDate)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@productName", o.ProductName);
                cmd.Parameters.AddWithValue("@productID", o.ProductID);
                cmd.Parameters.AddWithValue("@price", o.Price);
                cmd.Parameters.AddWithValue("@orderDate", o.OrderDate);
                cmd.Parameters.AddWithValue("@arrivalDate", o.ArrivalDate);

                Console.WriteLine(cmd.CommandText);
                message = cmd.CommandText;
                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }


        public bool Update(Order1 o)
        {


            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=IMS;User ID=sa;Password=tiger");
            try
            {


                string query = "Update into order (productName,productID,price,orderDate,arrivalDate)values(@productName,@productID,@price,@orderDate,@arrivalDate)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@productName", o.ProductName);
                cmd.Parameters.AddWithValue("@productID", o.ProductID);
                cmd.Parameters.AddWithValue("@price", o.Price);
                cmd.Parameters.AddWithValue("@orderDate", o.OrderDate);
                cmd.Parameters.AddWithValue("@arrivalDate", o.ArrivalDate);
                //Console.WriteLine(cmd.CommandText);
                //message = cmd.CommandText;

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }

        public bool Delete(Order1 o)
        {

            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=IMS;User ID=sa;Password=tiger");
            try
            {

                string query = "Delete from order where productID=@productID";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@productID", o.ProductID);

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }

    }
}
