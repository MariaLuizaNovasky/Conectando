using MySql.Data.MySqlClient;

namespace Conectando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "Server=localhost;user id=root;password=root;database=Turma;port=3306";
            con.Open();
            MessageBox.Show("A nossa conexões funcionou");
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                String data_Source = "Server=localhost;user id=root;password=root;database=Turma;port=3306");

                con = new MySqlConnection (data_Source);

                string sql = "insert into Aluno (nome, telefone, email) values (" + txtNome + "" + txtFone + "" + txtMail +"");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Conectou");
            }
        }
    }
}