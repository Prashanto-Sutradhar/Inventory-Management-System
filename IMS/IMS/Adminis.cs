using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace IMS
{
    class Adminis
    {
        //public string message;
        public string ID { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }



        public DataTable Select()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=IMS;User ID=sa;Password=tiger");

            DataTable dt = new DataTable();

            string query = "Select * from administration";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }


        public bool Insert(Adminis a)
        {


            bool isSuccess = false;



            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=IMS;User ID=sa;Password=tiger");
            try
            {



                string query = "Insert into administration (id,name,number,address,email)values(@id,@name,@number,@address,@email)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", a.ID);
                cmd.Parameters.AddWithValue("@name", a.Name);
                cmd.Parameters.AddWithValue("@number", a.Number);
                cmd.Parameters.AddWithValue("@address", a.Address);
                cmd.Parameters.AddWithValue("@email", a.Email);

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


        public bool Update(Adminis a)
        {


            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=IMS;User ID=sa;Password=tiger");
            try
            {


                string query = "Insert into administration (id,name,number,address,email)values(@id,@name,@number,@address,@email)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", a.ID);
                cmd.Parameters.AddWithValue("@name", a.Name);
                cmd.Parameters.AddWithValue("@number", a.Number);
                cmd.Parameters.AddWithValue("@address", a.Address);
                cmd.Parameters.AddWithValue("@email", a.Email);
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

        public bool Delete(Adminis a)
        {

            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=IMS;User ID=sa;Password=tiger");
            try
            {

                string query = "Delete from administration where id=@id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", a.ID);

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

