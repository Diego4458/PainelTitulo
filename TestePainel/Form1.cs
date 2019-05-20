using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace TestePainel
{
    public partial class painel : Form
    {
        public painel()
        {
            InitializeComponent();
            SqlDataReader contasinfo,Sociedades,online;
            string connectionString = GetCString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string soc = "Select * from Consortia";
                using (SqlCommand cmd = new SqlCommand(soc, connection))
                {
                    connection.Open();
                    Sociedades = cmd.ExecuteReader();
                    var contador = 0;
                    while (Sociedades.Read())
                    {
                        contador++;
                    }
                    Sociedade.Text = Convert.ToString(contador);
                  connection.Close();
                }

                string con = "Select * from Sys_Users_Detail";
                using (SqlCommand cmd = new SqlCommand(con, connection))
                {
                    connection.Open();
                    contasinfo = cmd.ExecuteReader();
                    var contador = 0;
                    while (contasinfo.Read())
                    {
                        contador++;
                    }
                    Contas.Text = Convert.ToString(contador);
                    connection.Close();
                }

                string onl = "Select (Online) from Server_List";
                using (SqlCommand cmd = new SqlCommand(onl, connection))
                {
                    connection.Open();
                    online = cmd.ExecuteReader();
                    if (online.Read())
                    {
                        int onlineagora = online.GetInt32(online.GetOrdinal("Online")); 
                        jogadores.Text = Convert.ToString(onlineagora);
                    }
                    connection.Close();
                }
            }


        }

        static private string GetCString()
        { return Convert.ToString(ConfigurationManager.ConnectionStrings["GetCString"]); }

        private void Titulo_Click(object sender, EventArgs e)
        {
            Form2 Tf = new Form2();
            Tf.Show();
        }

        private void painel_Load(object sender, EventArgs e)
        {

        }
    }
}
