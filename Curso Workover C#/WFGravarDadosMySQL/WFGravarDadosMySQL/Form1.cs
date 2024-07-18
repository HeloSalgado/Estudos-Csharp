using MySql.Data.MySqlClient;
<<<<<<< HEAD
using Mysqlx;
=======
>>>>>>> 1f48af0086b92808f4d2064e493c083e72fc74da

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
<<<<<<< HEAD
            lst_contatos.Columns.Add("Email", 180, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Telefone", 150, HorizontalAlignment.Left);

            CarregarContatos();
=======
            lst_contatos.Columns.Add("Email", 150, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Telefone", 150, HorizontalAlignment.Left);
>>>>>>> 1f48af0086b92808f4d2064e493c083e72fc74da
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar conexão
                conn = new MySqlConnection(data_source);

<<<<<<< HEAD
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = "insert into contato (nome, email, telefone) values (@nome, @email, @telefone)";

                cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                cmd.Parameters.AddWithValue("@telefone", txt_telefone.Text);

                cmd.Prepare();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Contato inserido com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_nome.Clear();
                txt_email.Clear();
                txt_telefone.Clear();

                CarregarContatos();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
=======
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
>>>>>>> 1f48af0086b92808f4d2064e493c083e72fc74da
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
<<<<<<< HEAD
                conn = new MySqlConnection(data_source);

                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = "SELECT * FROM contato WHERE nome LIKE @busca OR email LIKE @busca";

                cmd.Parameters.AddWithValue("@busca", $"%{txt_busca.Text}%");

                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();
=======
                string q = $"'%{txt_busca.Text}%'";

                // Criar conexão
                conn = new MySqlConnection(data_source);

                // Realizar select
                string sql = $"select * from contato where nome like {q} or email like {q}";

                conn.Open();

                MySqlCommand comando = new MySqlCommand(sql, conn);

                MySqlDataReader reader = comando.ExecuteReader();
>>>>>>> 1f48af0086b92808f4d2064e493c083e72fc74da

                lst_contatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row = {
<<<<<<< HEAD
                        reader.GetInt32(0).ToString(),
=======
                        reader.GetString(0),
>>>>>>> 1f48af0086b92808f4d2064e493c083e72fc74da
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

<<<<<<< HEAD
                    lst_contatos.Items.Add(new ListViewItem(row));
                }

                txt_busca.Clear();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void CarregarContatos()
        {
            try
            {
                conn = new MySqlConnection(data_source);

                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = "SELECT * FROM contato order by nome";

                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();

                lst_contatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row = {
                        reader.GetInt32(0).ToString(),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

                    lst_contatos.Items.Add(new ListViewItem(row));
                }

                txt_busca.Clear();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
=======
                    var linhaListView = new ListViewItem(row);

                    lst_contatos.Items.Add(linhaListView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
>>>>>>> 1f48af0086b92808f4d2064e493c083e72fc74da
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
