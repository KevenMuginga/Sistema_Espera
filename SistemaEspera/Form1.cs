using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SistemaEspera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-EFTV18J\SQLSERVE; integrated security = SSPI; initial Catalog = DB_SistemaEspera");
        SqlCommand command = new SqlCommand();
        public static int valorServico;
        
        private void LOGARBTN_Click(object sender, EventArgs e)
        {
            TelaLogin tela = new TelaLogin();
            tela.Show();

            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fichaPBalcao1.BringToFront();
            
            obtFicha.Hide();
                
           
            //this.Hide();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            valorServico = 1;
            obtFicha.Show();
        }

        private void obterFicha1_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            valorServico = 3;
            obtFicha.Show();
        }

        private void btnAcessarMusic_Click(object sender, EventArgs e)
        {
            valorServico = 2;
            obtFicha.Show();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            valorServico = 4;
            obtFicha.Show();
        }
    }
}
