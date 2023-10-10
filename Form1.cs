using System;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Enunciado_B
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = "Server=127.0.0.1;Uid=root;Pwd=usbw;Database=xyz";

        public Form1()
        {
            InitializeComponent();
        }

        // Evento para cadastrar ao clicar no botao 
        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            // Concectar ao banco de dados
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open(); // Inserir os dados no banco de dados


                    MySqlCommand cmd = new MySqlCommand("INSERT INTO produtos(codigo, nome, quantidade, fornecedor, pVenda, pCompra) VALUES (@codigo, @nome, @quantidade, @fornecedor, @pVenda, pCompra)", conn);
                    cmd.Parameters.AddWithValue("@codigo", codigo.Text);
                    cmd.Parameters.AddWithValue("@nome", nome.Text);
                    cmd.Parameters.AddWithValue("@quantidade", quantidade.Text);
                    cmd.Parameters.AddWithValue("@fornecedor", fornecedor.Text);
                    cmd.Parameters.AddWithValue("@pVenda", pVenda.Text);
                    cmd.Parameters.AddWithValue("@pCompra", pCompra.Text);
                    cmd.ExecuteNonQuery(); // consulta SQL para inserir os dados

                    // Mostrar as consultas no painel de exibição
                    painel.AppendText($"{nome.Text} | {codigo.Text} | {quantidade.Text} | {fornecedor.Text} | {pVenda.Text} | {pCompra.Text}" + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); // mostrar mensagem de erro
                }
            }
        }

        // Evento de pesquisa 
        private void pesquisa_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd;

                    if (pesquisa.Text.Length > 0)
                    {
                        cmd = new MySqlCommand("SELECT nome, codigo, quantidade FROM produtos WHERE nome LIKE @pesquisa", conn);
                        cmd.Parameters.AddWithValue("@pesquisa", $"%{pesquisa.Text}%"); // Procura pelo termo
                    }
                    else
                    // Mostra todos os produtos se caso não encontrar
                    {
                        cmd = new MySqlCommand("SELECT nome, codigo, quantidade FROM produtos", conn);
                    }

                    // consulta para recuperar os dados
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        StringBuilder codigosEncontrados = new StringBuilder();

                        while (reader.Read())
                        {
                            // manipulando o resultado para aparecer de forma que xista uma barra separando cada tipo de dado
                            codigosEncontrados.AppendLine($"{reader["nome"].ToString()} | {reader["codigo"].ToString()} | {reader["quantidade"].ToString()} | {reader["fornecedor"].ToString()} | {reader["pVenda"].ToString()} | {reader["pCompra"].ToString()}");
                        }

                        // atualizar o plainel com o resultado da pesquisa 
                        if (codigosEncontrados.Length > 0)
                        {
                            painel.Text = codigosEncontrados.ToString();
                        }
                        else // isso se não encontrar nenhum
                        {
                            painel.Text = "Nenhum resultado encontrado.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void botaoApagar_Click(object sender, EventArgs e)
        { // evento para o botão ter um evento de apagar
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    // conectar com o banco de dados novamente
                    // comando para o achar pelo codigo e deletar do sistema
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM produtos WHERE codigo = @codigo", conn);
                    cmd.Parameters.AddWithValue("@codigo", apagar.Text);

                    int MexerLinha = cmd.ExecuteNonQuery();

                    // Atualizar o painel de exibição com uma mensagem com base em se o produto foi excluído ou não
                    if (MexerLinha > 0)
                    {
                        painelApagar.Text = $"{apagar.Text} | Este produto está excluído.";
                    }
                    else
                    {
                        painelApagar.Text = $"Produto com código {apagar.Text} não encontrado.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        }
    }

