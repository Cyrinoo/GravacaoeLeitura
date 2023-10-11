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

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO produtos(codigo, nome, quantidade, fornecedor, pVenda, pCompra) VALUES (@codigo, @nome, @quantidade, @fornecedor, @pVenda, @pCompra)", conn);
                    cmd.Parameters.AddWithValue("@codigo", codigo.Text);
                    cmd.Parameters.AddWithValue("@nome", nome.Text);
                    cmd.Parameters.AddWithValue("@quantidade", quantidade.Text);
                    cmd.Parameters.AddWithValue("@fornecedor", fornecedor.Text);
                    cmd.Parameters.AddWithValue("@pVenda", pVenda.Text);
                    cmd.Parameters.AddWithValue("@pCompra", pCompra.Text);
                    cmd.ExecuteNonQuery();

                    // Após a inserção, verifique se a quantidade está abaixo do mínimo
                    int quantidadeAtual = Convert.ToInt32(quantidade.Text);
                    if (quantidadeAtual < 10)
                    {
                        MessageBox.Show("Quantidade abaixo do mínimo. É hora de encomendar mais.");
                    }
                    if(quantidadeAtual > 30)
                    {
                        MessageBox.Show("Quantidade maior que o permitido.");
                    }
                    // Atualize o painel com os dados inseridos
                    painel.AppendText($"{nome.Text} | {codigo.Text} | {quantidade.Text} | {fornecedor.Text} | {pVenda.Text} | {pCompra.Text}" + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void botaoApagar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("DELETE FROM produtos WHERE codigo = @codigo", conn);
                    cmd.Parameters.AddWithValue("@codigo", apagar.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        painelApagar.Text = $"{apagar.Text} | Este produto foi excluído.";
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
                        cmd.Parameters.AddWithValue("@pesquisa", $"%{pesquisa.Text}%");
                    }
                    else
                    {
                        cmd = new MySqlCommand("SELECT nome, codigo, quantidade FROM produtos", conn);
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        StringBuilder produtosEncontrados = new StringBuilder();

                        while (reader.Read())
                        {
                            produtosEncontrados.AppendLine($"{reader["nome"].ToString()} | {reader["codigo"].ToString()} | {reader["quantidade"].ToString()}");
                        }

                        if (produtosEncontrados.Length > 0)
                        {
                            painel.Text = produtosEncontrados.ToString();
                        }
                        else
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
    }
}
