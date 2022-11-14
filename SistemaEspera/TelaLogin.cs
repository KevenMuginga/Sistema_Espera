using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SistemaEspera
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        SqlConnection sqlConn = new SqlConnection(@"Data Source = DESKTOP-EFTV18J\SQLSERVE; integrated security = SSPI; initial Catalog = SistemaDeEsperaPro");
        SqlCommand command = new SqlCommand();
        public static String user;
        public static int idPessoa;

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Preencha os Campos UserName e Senha", "Erro ao Logar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();

            }
            else
            {

                try
                {

                    string sql = "select * from TB_Pessoa where userName = ('" + txtUserName.Text + "') and senha = ('" + txtPassword.Text + "')";
                    command.CommandText = sql;
                    command.Connection = sqlConn;
                    sqlConn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        Console.WriteLine("Logando");
                        //MessageBox.Show("Login feito com Sucesso");

                        user = table.Rows[0]["UserName"].ToString();
                        idPessoa = Convert.ToInt32(table.Rows[0]["userId"].ToString());

                        sqlConn.Close();
                        Console.WriteLine("logado");

                        //Balcao balc = new Balcao();
                        //balc.Show();

                        Balcoes balc = new Balcoes();
                        balc.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("UserName ou Password errados", "Erro Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sqlConn.Close();
                }
                finally
                {
                    sqlConn.Close();
                }

            }
        }
    }
}
