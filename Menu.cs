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
        }

        private void Titulo_Click(object sender, EventArgs e)
        {
            Titulo dale = new Titulo();
            dale.Show();
        }

        private void painel_Load(object sender, EventArgs e)
        {

        }

        private void Missoes_Click(object sender, EventArgs e)
        {
            Limpar Tf = new Limpar();
            Tf.Show();
        }
    }
}
