using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaEspera
{
    public partial class ObterFicha : UserControl
    {
        public ObterFicha()
        {
            InitializeComponent();

        }

        SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-EFTV18J\SQLSERVE; integrated security = SSPI; initial Catalog = SistemaDeEsperaPro");
        SqlCommand command = new SqlCommand();

        int userId;
        int tempo = 10;
        public static int fichha = 0;
        public static DateTime data = DateTime.Now;
        Ficha ficha = new Ficha();

        private void btnficha_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            if (usuario.SelectUser(data, 1).Count > 0)
            {
                userId = Convert.ToInt32(usuario.SelectUser(data, 1)[0].id.ToString());
                //  MessageBox.Show("hjhj");
                fichha++;


                ficha.ficha = fichha;
                ficha.datta = data;
                ficha.servico = Form1.valorServico;

                ficha.InsertFicha(ficha);
                MessageBox.Show("" + fichha, "A sua ficha é", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (ficha.SelectFicha(data, fichha).Count > 0)
                {
                    //insere a ficha na Table Balcao

                    int selectFicha = Convert.ToInt32(ficha.SelectFicha(data, fichha)[0].id.ToString());

                    Balcao balcao = new Balcao();

                    balcao.insertBalcao(userId, selectFicha);


                }

                tempo = 10;
                this.Hide();

            }
            else
            {
                MessageBox.Show("Balcao INACTIVO no momento aguarde", "BALCÃO INACTIVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tempo--;
            lblTempo.Text = tempo.ToString();

            if (tempo == 0)
            {
                this.Hide();
                tempo = 10;

            }
        }

        private void ObterFicha_Load(object sender, EventArgs e)
        {
            tempo = 10;

            if (ficha.SelectFicha(data).Count > 0)
            {
                Ficha fich = new Ficha();
                var fichh = ficha.SelectFicha(data)[ficha.SelectFicha(data).Count - 1];

                fichha = fichh.ficha;
            }
            else
            {
                MessageBox.Show("Sem Ficha ");

            }

            this.timer.Enabled = true;


        }
    }
}
