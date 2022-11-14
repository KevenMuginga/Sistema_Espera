using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEspera
{
    public partial class FichaPBalcao : UserControl
    {
        public FichaPBalcao()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-EFTV18J\SQLSERVE; integrated security = SSPI; initial Catalog = SistemaDeEsperaPro");
        SqlCommand command = new SqlCommand();

        //int fichaId;
        public static int tempo = 1;
        DateTime data = DateTime.Now;

        public void fichas()
        {
            Ficha ficha = new Ficha();

            lblFichaGame.Text = Convert.ToString(ficha.selectFichPBalcao(data, "TRUE", 1).ficha);
            lblMusic.Text = Convert.ToString(ficha.selectFichPBalcao(data, "TRUE", 2).ficha);
            lblPicture.Text = Convert.ToString(ficha.selectFichPBalcao(data, "TRUE", 3).ficha);
            lblBook.Text = Convert.ToString(ficha.selectFichPBalcao(data, "TRUE", 4).ficha);
        }
        
        private void FichaPBalcao_Load(object sender, EventArgs e)
        {
            fichas();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void timerPBalcao_Tick(object sender, EventArgs e)
        {
            tempo--;

            if (tempo == 0)
            {                
                tempo = 1;
                fichas();

            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
