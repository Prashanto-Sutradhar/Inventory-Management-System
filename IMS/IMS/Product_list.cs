using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace IMS
{
    class Product_list
    {
        public string message;
        public string P_Name { get; set; }
        public string P_ID { get; set; }
        public string P_Catagory { get; set; }
        public string P_Date { get; set; }
        public string P_Price { get; set; }
       


        public DataTable Select()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=IMS;User ID=sa;Password=tiger");

            DataTable dt = new DataTable();

            string query = "Select * from ProductList";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }


        public bool Insert(Product_list cl)
        {


            bool isSuccess = false;



            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=IMS;User ID=sa;Password=tiger");
            try
            {



                string query = "Insert into ProductList (p_name,p_id,p_catagory,p_date,p_price)values(@p_name,@p_id,@p_catagory,@p_date,@p_price)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@p_name", cl.P_Name);
                cmd.Parameters.AddWithValue("@p_id", cl.P_ID);
                cmd.Parameters.AddWithValue("@p_catagory", cl.P_Catagory);
                cmd.Parameters.AddWithValue("@p_date", cl.P_Date);
                cmd.Parameters.AddWithValue("@p_price", cl.P_Price);
                
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


        public bool Update(Product_list cl)
        {


            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=IMS;User ID=sa;Password=tiger");
            try
            {


                string query = "Update ProductList set P_Name=@p_name, P_Catagory=@p_catagory, P_Date=@p_date, P_Price=@p_price where P_ID=@p_id";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@p_name", cl.P_Name);
                cmd.Parameters.AddWithValue("@p_id", cl.P_ID);
                cmd.Parameters.AddWithValue("@p_catagory", cl.P_Catagory);
                cmd.Parameters.AddWithValue("@p_date", cl.P_Date);
                cmd.Parameters.AddWithValue("@p_price", cl.P_Price);
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

        public bool Delete(Product_list cl)
        {

            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=IMS;User ID=sa;Password=tiger");
            try
            {

                string query = "Delete from ProductList where p_id=@p_id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@p_id", cl.P_ID);

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
