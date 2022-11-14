using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Media;

namespace SistemaEspera
{
    public partial class AtenderCliente : UserControl
    {
        public AtenderCliente()
        {
            InitializeComponent();
        }

        Ficha ficha = new Ficha();

        public static int idFicha;
        public static int fichha;

        int tempo = 5;

        DateTime data = DateTime.Now;

        SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-EFTV18J\SQLSERVE; integrated security = SSPI; initial Catalog = SistemaDeEsperaPro");
        SqlCommand command = new SqlCommand();
        private void AtenderCliente_Load(object sender, EventArgs e)
        {
            tblDados.DataSource = ficha.SelectFicha(data, "ON", PaneBalcao.valorServico);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (tblDados.SelectedRows.Count == -1)
            {
                MessageBox.Show("Selecione uma linha'ficha' para ser chamada");
                btnChamar.Enabled = true;
            }
            else
            {

                idFicha = Convert.ToInt32(tblDados.SelectedRows[0].Cells[0].Value.ToString());
                fichha = Convert.ToInt32(tblDados.SelectedRows[0].Cells[1].Value.ToString());

                //inserir Ficha Na TB CALLED
                Called called = new Called();
                called.insertCalled(idFicha, data, PaneBalcao.valorServico);


                lblId.Text = "Id: " + idFicha;
                lblFicha.Text = "Ficha: " + fichha;

                //Actualizar todos fichas para CALLED na TB_CALLED 
                called.updateCalled(idFicha, PaneBalcao.valorServico);

                //Actualizar estado da Ficha 
                ficha.updateFicha(idFicha, PaneBalcao.valorServico);
                tempo = 1;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            tempo--;
            if (tempo == 0)
            {
                tblDados.DataSource = ficha.SelectFicha(data, "ON", PaneBalcao.valorServico);


            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            //Balcoes balc = new Balcoes();
            //balc.BringToFront();
            //balc.Show();
            this.Hide();
        }
    }
}
