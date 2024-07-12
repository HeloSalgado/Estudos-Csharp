using MySql.Data.MySqlClient;

namespace WFGravarDadosMySQL
{
    public partial class Form1 : Form
    {
        private MySqlConnection? conn;
        private string data_source = "datasource=localhost;username=root;password=25101724;database=db_agenda";

        public Form1()
        {
            InitializeComponent();

            lst_contatos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Email", 150, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Telefone", 150, HorizontalAlignment.Left);
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar conexão
                conn = new MySqlConnection(data_source);

                // Realizar insert
                string sql = $"insert into contato (nome, email, telefone) values ('{txt_nome.Text}', '{txt_email.Text}', '{txt_telefone.Text}')";

                MySqlCommand comando = new MySqlCommand(sql, conn);

                conn.Open();
                comando.ExecuteReader();

                MessageBox.Show("Deu tudo certo, inserido");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string q = $"'%{txt_busca.Text}%'";

                // Criar conexão
                conn = new MySqlConnection(data_source);

                // Realizar select
                string sql = $"select * from contato where nome like {q} or email like {q}";

                conn.Open();

                MySqlCommand comando = new MySqlCommand(sql, conn);

                MySqlDataReader reader = comando.ExecuteReader();

                lst_contatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row = {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

                    var linhaListView = new ListViewItem(row);

                    lst_contatos.Items.Add(linhaListView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
