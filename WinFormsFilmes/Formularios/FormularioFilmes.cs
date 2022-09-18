using RestSharp;
using WinFormsFilmes.Model;


namespace WinFormsFilmes.Formularios
{
    public partial class FormularioFilmes : Form
    {
        string url = "https://localhost:7268";
        RestClient client;
        public FormularioFilmes()
        {
            client = new RestClient(url);
            InitializeComponent();
        }

        private void botaoGet_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new RestRequest("/Filme", Method.Get);
                var response = client.ExecuteGet<List<Filme>>(request);
                dataGridViewFilmes.DataSource = response.Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void botaoGetId_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new RestRequest($"/Filme/{textBoxId.Text}", Method.Get);
                var response = client.ExecuteGet<List<Filme>>(request);
                if (textBoxId.Text == string.Empty || response.Data.Count == 0)
                {
                    MessageBox.Show("Filme não encontrado com o Id especificado");
                }
                else
                {
                    dataGridViewFilmes.DataSource = response.Data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void botaoPost_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new RestRequest("/Filme", Method.Post);                
                request.AddBody(new Filme
                {
                    Titulo = textBoxTitulo.Text,
                    Diretor = textBoxDiretor.Text,
                    Genero = textBoxGenero.Text,
                    Duracao = Convert.ToInt32(textBoxDuracao.Text),
                });
                client.Execute(request);
                MessageBox.Show("Filme Adicionado com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }           

        private void dataGridViewFilmes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int localizaLinhaSelecionada = dataGridViewFilmes.CurrentCell.RowIndex;
            var Id = $"{dataGridViewFilmes.Rows[localizaLinhaSelecionada].Cells[0].Value}";
            switch (e.ColumnIndex)
            {
                case 5:
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("Deseja realmente apagar esse Filme?", "Filmes",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            var request = new RestRequest($"/Filme/{Id}", Method.Delete);
                            client.Execute(request);
                            MessageBox.Show("Filme Deletado com Sucesso!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 6:
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("Deseja realmente Atualizar esse Filme?", "Filmes",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            var request = new RestRequest($"/Filme/{Id}", Method.Put);
                            request.AddBody(new Filme
                            {
                                Id = Convert.ToInt32($"{dataGridViewFilmes.Rows[localizaLinhaSelecionada].Cells[0].Value}"),
                                Titulo = $"{dataGridViewFilmes.Rows[localizaLinhaSelecionada].Cells[1].Value}",
                                Diretor = $"{dataGridViewFilmes.Rows[localizaLinhaSelecionada].Cells[2].Value}",
                                Genero = $"{dataGridViewFilmes.Rows[localizaLinhaSelecionada].Cells[3].Value}",
                                Duracao = Convert.ToInt32($"{dataGridViewFilmes.Rows[localizaLinhaSelecionada].Cells[4].Value}")
                            });
                            client.Execute(request);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }
    }
}