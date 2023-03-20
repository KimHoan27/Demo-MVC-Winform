using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_Coffee.DAO
{
    class clsDB
    {
        
        private static clsDB instance;
        //Tạo kết nối
        private string conSTR = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Quanlyquancoffee;Integrated Security=True";
        //Thiết kế patern Singleton, biến Instance thể hiện một lớp duy nhất
        public static clsDB Instance
        {
            get { if (instance == null) instance = new clsDB(); return clsDB.instance; }
            private set { clsDB.instance = value; }
        }
        private clsDB(){}

        //Phương thức này dùng để thực thi câu truy vấn
        //Using: dùng để giải phóng bộ nhớ khi kết nối đã đóng
        public DataTable execQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection con = new SqlConnection(conSTR))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(data);

                con.Close();
            }

            return data;
        }
        //Phương thức này trả về số hàng được thực hiện bởi truy vấn
        //Using: dùng để giải phóng bộ nhớ khi kết nối đã đóng
        public int execNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection con = new SqlConnection(conSTR))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteNonQuery();

                con.Close();
            }

            return data;
        }
        //Phương thức này trả về giá trị hàng đầu tiên và cột đầu tiên của kết quả truy vấn.
        //Using: dùng để giải phóng bộ nhớ khi kết nối đã đóng
        public object execScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection con = new SqlConnection(conSTR))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteScalar();

                con.Close();
            }

            return data;
        }
    }
}
