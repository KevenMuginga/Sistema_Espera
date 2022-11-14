using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SistemaEspera
{
    public partial class Balcoes : Form
    {
        public Balcoes()
        {
            InitializeComponent();
        }

        private void Balcao_Load(object sender, EventArgs e)
        {
            PaneBalcao panebalc = new PaneBalcao();
            panebalc.BringToFront();
            fichaPBalcao1.Hide();

            
            

        }

        private void atenderCliente1_Load(object sender, EventArgs e)
        {
           
        }

        private void paneBalcao1_Load(object sender, EventArgs e)
        {

        }

        private void paneBalcao1_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //paneBalcao1.SendToBack();
            fichaPBalcao1.Show();
            
        }

        private void fichaPBalcao1_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            paneBalcao1.BringToFront();
        }
    }
}
