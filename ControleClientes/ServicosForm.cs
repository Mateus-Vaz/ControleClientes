using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleClientes
{
    public partial class ServicoForm : Form
    {
        private readonly ServicoRepository _repository;
        private int? editingId = null;


        public ServicoForm()
        {
            InitializeComponent();
            _repository = new ServicoRepository();
            AtualizarGrid();

        }
        private void AtualizarGrid()
        {
            var clientes = _repository.ListarTodos();
            gridServicos.AutoGenerateColumns = false;
            gridServicos.DataSource = clientes;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            txtCategoria.Clear();


            editingId = null;
            gridServicos.ClearSelection();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();

            tcServico.SelectTab(tpServicoCadastro);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var Servico = new Servico()
            {
                Nome = txtNome.Text.Trim(),
                Descricao = txtDescricao.Text.Trim(),                
                Categoria = txtCategoria.Text.Trim(),
                Preco = txtPreco.Text.Trim(),

            };
            if (editingId == null)
                _repository.Adicionar(Servico);
            else
            {
                Servico.Id = editingId.Value;
                _repository.Atualizar(Servico);
            }
            LimparCampos();
            AtualizarGrid();
            tcServico.SelectTab(tpServicoConsulta);



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tcServico.SelectTab(tpServicoConsulta);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (gridServicos.SelectedRows.Count == 0)
                return;
            if (MessageBox.Show("Excluir registro?", "Servicos",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var cliente = (Servico)gridServicos.SelectedRows[0].DataBoundItem;
                _repository.Remover(cliente.Id);
                AtualizarGrid();
                tcServico.SelectTab(tpServicoConsulta);
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (gridServicos.SelectedRows.Count == 0)
                return;

            var Servico = (Servico)gridServicos.SelectedRows[0].DataBoundItem;
            txtNome.Text = Servico.Nome;
            txtDescricao.Text = Servico.Descricao;
            txtCategoria.Text = Servico.Categoria;
            txtPreco.Text = Servico.Preco;



            editingId = Servico.Id;
            tcServico.SelectTab(tpServicoCadastro);
        }

        private async Task<Endereco> BuscarCepAsync(string cep)
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<Endereco>(responseBody);
                }
                else
                    throw new Exception($"Consultando o CEP. Código de status: {response.StatusCode}");
            }
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var clientes = _repository.ObterPorNome(txtPesquisarNome.Text);
            gridServicos.AutoGenerateColumns = false;
            gridServicos.DataSource = clientes;

        }

        
    }
}
