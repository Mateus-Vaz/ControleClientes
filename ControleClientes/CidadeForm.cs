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
    public partial class CidadeForm : Form 
    {
        private readonly CidadeRepository _repository;
        private int? editingId = null;
        


      
       

        public CidadeForm()
        {
            InitializeComponent();            
            _repository = new CidadeRepository();
            AtualizarGrid();
          
        }
        private void AtualizarGrid()
        {
            var clientes = _repository.ListarTodos();
            gridCidades.AutoGenerateColumns = false;
            gridCidades.DataSource = clientes;
        }

        private void LimparCampos()
        {
            txtNome.Clear();            
            txtUf.Clear();


            
            editingId = null;
            gridCidades.ClearSelection();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();

            tcCidade.SelectTab(tpCidadeCadastro);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            

            
           
            var cidade = new Cidade()
            {
                Nome = txtNome.Text.Trim(),                
                Uf = txtUf.Text.Trim(),
               



            };
            if (editingId == null)
                _repository.Adicionar(cidade);
            else
            {
                cidade.Id = editingId.Value;
                _repository.Atualizar(cidade);
            }
            LimparCampos();
            AtualizarGrid();
            tcCidade.SelectTab(tpCidadeConsulta);



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tcCidade.SelectTab(tpCidadeConsulta);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (gridCidades.SelectedRows.Count == 0)
                return;
            if (MessageBox.Show("Excluir registro?", "Cidades",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var cliente = (Cidade)gridCidades.SelectedRows[0].DataBoundItem;
                _repository.Remover(cliente.Id);
                AtualizarGrid();
                tcCidade.SelectTab(tpCidadeConsulta);
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (gridCidades.SelectedRows.Count == 0)
                return;

            var cidade = (Cidade)gridCidades.SelectedRows[0].DataBoundItem;
            txtNome.Text = cidade.Nome;            
            txtUf.Text = cidade.Uf;


            
                     

            editingId = cidade.Id;
            tcCidade.SelectTab(tpCidadeCadastro);
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
            gridCidades.AutoGenerateColumns = false;
            gridCidades.DataSource = clientes;

        }
    }
}
