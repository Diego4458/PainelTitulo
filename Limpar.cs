using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using TestePainel.Functions;
using TestePainel.Data;
using System.Data;
using System.Collections.Generic;

namespace TestePainel
{
    public partial class Limpar : Form
    {

        public Shop_Goods_Box[] Box;
        public Shop_Goods[] Itens;
        public Limpar()
        {
            InitializeComponent();
            Box = ShopBoxLoader();
            Itens = ItensLoader();
            label2.Text = Itens.Length.ToString();
            label1.Text = Box.Length.ToString();
            label6.Text = ITFDJ().ToString();
        }

        int ITFDJ()
        {
            int a = 0;
            for(int x =0;x<Box.Length;x++)
            {
                for(int y = 0; y < Itens.Length;y++)
                {
                   if(Box[x].ID == Itens[y].TemplateID)
                    {
                        break;
                    }
                   else if(y+1 == Itens.Length)
                    {
                        a += 1;
                        break;
                    }
                }
            }
            return a;
        }

       Shop_Goods_Box[] ShopBoxLoader()
        {
            SqlDataReader SoapBox;
            List<Shop_Goods_Box> dados = new List<Shop_Goods_Box>();
            string soc = "Select * from Shop_Goods_Box";
            using (SqlConnection connection = new SqlConnection(Global.DbTank()))
            {
                using (SqlCommand cmd = new SqlCommand(soc, connection))
                {
                    connection.Open();
                    SoapBox = cmd.ExecuteReader();
                    while (SoapBox.Read())
                    {
                        Shop_Goods_Box dale = new Shop_Goods_Box();
                        dale.ID = SoapBox.GetInt32(SoapBox.GetOrdinal("ID"));
                        dados.Add(dale);
                    }
                    connection.Close();
                }

            }
            return dados.ToArray();
        }

        Shop_Goods[] ItensLoader()
        {
            SqlDataReader SoapBox;
            List<Shop_Goods> dados = new List<Shop_Goods>();
            string soc = "Select * from Shop_Goods";
            using (SqlConnection connection = new SqlConnection(Global.DbTank()))
            {
                using (SqlCommand cmd = new SqlCommand(soc, connection))
                {
                    connection.Open();
                    SoapBox = cmd.ExecuteReader();
                    while (SoapBox.Read())
                    {
                        Shop_Goods dale = new Shop_Goods();
                        dale.TemplateID = SoapBox.GetInt32(SoapBox.GetOrdinal("TemplateID"));
                        dados.Add(dale);
                    }
                    connection.Close();
                }

            }
            return dados.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            for (int x = 0; x < Box.Length; x++)
            {
                for (int y = 0; y < Itens.Length; y++)
                {
                    if (Box[x].ID == Itens[y].TemplateID)
                    {
                        break;
                    }
                    else if (y + 1 == Itens.Length)
                    {
                        a += 1;
                        string soc = String.Format("Delete from Shop_Goods_Box where Id = {0}", Box[x].ID); ;
                        using (SqlConnection connection = new SqlConnection(Global.DbTank()))
                        {
                            using (SqlCommand cmd = new SqlCommand(soc, connection))
                            {
                                connection.Open();
                                cmd.ExecuteReader();
                                connection.Close();
                            }

                        }


                        break;
                    }
                }
            }
            MessageBox.Show(String.Format("Você Deletou {0} Baús(Itens De Caixa) Inexistentes"),a.ToString());
        }
    }
}
