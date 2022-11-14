using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SistemaEspera
{
    public partial class PaneBalcao : UserControl
    {
        public PaneBalcao()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-EFTV18J\SQLSERVE; integrated security = SSPI; initial Catalog = SistemaDeEsperaPro");
        SqlCommand command = new SqlCommand();

        //int id = TelaLogin.idUser;

        public static int valorServico;
        String nome = TelaLogin.user;
        DateTime data = DateTime.Now;

        private void btnAcessarGame_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            valorServico = 1;
            usuario.insertUser(data, valorServico);

            AtenderCliente att = new AtenderCliente();
            att.BringToFront();
            this.Hide();
                       
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            valorServico = 2;
            usuario.insertUser(data, valorServico);

            AtenderCliente att = new AtenderCliente();
            att.BringToFront();
            this.Hide();
        }

        private void btnAcessarPicture_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            valorServico = 3;
            usuario.insertUser(data, valorServico);

            AtenderCliente att = new AtenderCliente();
            att.BringToFront();
            this.Hide();
        }

        private void btnAcessarBooks_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            valorServico = 4;
            usuario.insertUser(data, valorServico);

            AtenderCliente att = new AtenderCliente();
            att.BringToFront();
            this.Hide();
        }
    }
}
