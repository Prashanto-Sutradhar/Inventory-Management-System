using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace IMS
{
    class Catagories
    {
        //public string message;
        public string P_Catagory { get; set; }
        public string P_Quantity { get; set; }
        



        public DataTable Select()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=IMS;User ID=sa;Password=tiger");

            DataTable dt = new DataTable();

            string query = "Select * from catagory";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }


        public bool Insert(Catagories cg)
        {


            bool isSuccess = false;



            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=IMS;User ID=sa;Password=tiger");
            try
            {



                string query = "Insert into catagory (p_catagory,p_quantity)values(@p_catagory,@p_quantity)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@p_catagory", cg.P_Catagory);
                cmd.Parameters.AddWithValue("@p_quantity", cg.P_Quantity);
                

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


        public bool Update(Catagories cg)
        {


            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=IMS;User ID=sa;Password=tiger");
            try
            {


                string query = "Update catagory set P_Catagory=@p_catagory, P_Quantity=@p_quantity where P_Catagory=@p_catagory";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@p_catagory", cg.P_Catagory);
                cmd.Parameters.AddWithValue("@p_quantity", cg.P_Quantity);
                
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

        public bool Delete(Catagories cg)
        {

            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=IMS;User ID=sa;Password=tiger");
            try
            {

                string query = "Delete from catagory where p_catagory=@p_catagory";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@p_catagory", cg.P_Catagory);

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

