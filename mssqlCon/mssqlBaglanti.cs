using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mssqlCon
{
    public class mssqlBaglanti
    {
        //Made By: Burak Sakallı
        //Web: www.buraksakalli.org
        //Mail: dev@buraksakalli.org

        SqlCommand cm = new SqlCommand();
        string don;

        public string mssqlBaglan(string type,string server, string conString)
        {
            SqlConnection baglanti = new SqlConnection(server);
            if (type == "notSelect")
            {
                try
                {  
                    cm.Connection = baglanti;
                    cm.CommandText = conString;
                    baglanti.Open();
                    cm.ExecuteNonQuery();
                    baglanti.Close();
                    don = "Başarılı";
                }
                catch (Exception e)
                {
                    don = "Hata!\n" + e.ToString();
                }
                
            }
            if (type == "Select")
            {
                try
                {
                    cm.Connection = baglanti;
                    cm.CommandText = conString;
                    baglanti.Open();

                    SqlDataReader sr = cm.ExecuteReader();
                    while (sr.Read())
                    {
                        don = sr + "\n" + don;
                    }
                    sr.Close();
                    baglanti.Close();
                }
                catch(Exception e)
                {
                    don = "Error\n" + e.ToString();
                }
            }
            return don;
        }
    }
}
