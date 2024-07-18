using MySql.Data.MySqlClient;
using Mysqlx;
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WFGravarDadosMySQL
{
    public partial class Form1 : Form
    {
        private MySqlConnection? conn;
        private string data_source = "datasource=localhost;username=root;password=25101724;database=db_agenda";
        private int? idContatoSelecionado = null;

        public Form1()
        {
            InitializeComponent();

            lst_contatos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Email", 180, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Telefone", 150, HorizontalAlignment.Left);

            CarregarContatos();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar conexão
                conn = new MySqlConnection(data_source);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = "insert into contato (nome, email, telefone) values (@nome, @email, @telefone)";

                if (idContatoSelecionado != null)
                {
                    cmd.CommandText = "update contato set nome = @nome, email = @email, telefone = @telefone where id = @id;";
                    cmd.Parameters.AddWithValue("@id", idContatoSelecionado);
                }

                cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                cmd.Parameters.AddWithValue("@telefone", txt_telefone.Text);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Operação efetuada com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_nome.Clear();
                txt_email.Clear();
                txt_telefone.Clear();
                idContatoSelecionado = null;

                CarregarContatos();
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(data_source);

                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = "SELECT * FROM contato WHERE nome LIKE @busca OR email LIKE @busca";

                cmd.Parameters.AddWithValue("@busca", $"%{txt_busca.Text}%");

                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();

                lst_contatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row = [
                        reader.GetInt32(0).ToString(),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    ];

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
                    string[] row = [
                        reader.GetInt32(0).ToString(),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    ];

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

        private void lst_contatos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itensSelecionados = lst_contatos.SelectedItems;

            foreach (ListViewItem item in itensSelecionados)
            {
                idContatoSelecionado = Convert.ToInt32(item.SubItems[0].Text);
                txt_nome.Text = item.SubItems[1].Text;
                txt_email.Text = item.SubItems[2].Text;
                txt_telefone.Text = item.SubItems[3].Text;
            }
        }
    }
}
