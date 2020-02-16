using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using TestePainel.Functions;
using System.Configuration;
using System.Data;

namespace TestePainel
{
    public partial class Titulo : Form
    {
        public Titulo()
        {
            InitializeComponent();

            SqlDataReader tituloBox;
            using (SqlConnection connection = new SqlConnection(Global.DbTank()))
            {
                string tituloS = "SELECT ID,Name FROM dbo.New_Title";
                using (SqlCommand cmd = new SqlCommand(tituloS, connection))
                {
                    connection.Open();
                    tituloBox = cmd.ExecuteReader();
                    DataTable tabela = new DataTable();
                    tabela.Columns.Add("ID", typeof(int));
                    tabela.Columns.Add("Name", typeof(string));
                    tabela.Load(tituloBox);
                    Tilt.DataSource = tabela;
                    Tilt.DisplayMember = "Name";
                    Tilt.ValueMember = "ID";
                    connection.Close();
                }
            }
        }

        private void Mandar_Click(object sender, EventArgs e)
        {
            if (login.Text != "")
            {
                String titulonome = "nada";
            int resultado = 0;
            SqlDataReader useridd,leitor;
                using (SqlConnection connection = new SqlConnection(Global.DbTank()))
                {

                    string verif = "SELECT ID,Name FROM dbo.New_Title where ID = @id";
                    using (SqlCommand cmd = new SqlCommand(verif, connection))
                    {
                        connection.Open();

                        cmd.Parameters.Add(new SqlParameter("@id", this.Tilt.SelectedValue));
                        leitor = cmd.ExecuteReader();

                    }

                    if (leitor.Read())
                    {
                        titulonome = leitor.GetString(leitor.GetOrdinal("Name"));
                    }
                    else
                    {
                        MessageBox.Show("Não Leu o Titulo", "Erro");
                    }
                    connection.Close();
                }
                using (SqlConnection connection = new SqlConnection(Global.Tank_1()))
                {
                string check = "select UserID from Sys_Users_Detail where username = @login";
                using (SqlCommand cmd = new SqlCommand(check, connection))
                {
                    connection.Open();
                    string NL = login.Text;
                    cmd.Parameters.Add(new SqlParameter("@login", NL));
                    useridd = cmd.ExecuteReader();
                   
                }

                if (useridd.Read())
                {
                    resultado = useridd.GetInt32(useridd.GetOrdinal("userid"));
                }
                connection.Close();
                string insert = "INSERT INTO Sys_User_Rank (Userid,NewtitleID,Name,isExit)" + "Values (@Userid,@NewtitleID,@Name,@isExit)";
                using (SqlCommand cmd = new SqlCommand(insert, connection))
                {

                    connection.Open();
                    if (resultado != 0 && titulonome != "nada" && titulonome != "")
                    {

                        cmd.Parameters.Add(new SqlParameter("@Userid", resultado));
                        cmd.Parameters.Add(new SqlParameter("@NewtitleID", this.Tilt.SelectedValue));
                        cmd.Parameters.Add(new SqlParameter("@Name", titulonome));
                        cmd.Parameters.Add(new SqlParameter("@isExit", 1));
                        MessageBox.Show("Titulo Enviado", "Sucesso");
                        cmd.ExecuteNonQuery();
                       
                    }
                    else
                    {
                        MessageBox.Show("Login Errado ou Vazio", "Erro");
                    }
                    connection.Close();
                }
            }
             }
            else
            {
                MessageBox.Show("Usuario Vazio");
            }
        }


    }
}
