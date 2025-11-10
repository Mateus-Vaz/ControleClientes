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
    public partial class ClienteForm : Form 
    {
        private readonly ClienteRepository _repository;
        private int? editingId = null;
        private List<Cidade> _cidades;


        List<ItemGenero> itemGeneros = new List<ItemGenero>()
        {
            new ItemGenero() { Valor = Genero.Masculino, Descricao = "Masculino" },
            new ItemGenero() { Valor = Genero.Feminino, Descricao = "Feminino" }
        };
        List<ItemEstadoCivil> itemEstadoCivil = new List<ItemEstadoCivil>()
        {
            new ItemEstadoCivil() { Valor = EstadoCivil.Casado, Descricao = "Casado" },
            new ItemEstadoCivil() { Valor = EstadoCivil.solteiro, Descricao = "Solteiro" },
            new ItemEstadoCivil() { Valor = EstadoCivil.Divorciado, Descricao = "Divorciado" },
            new ItemEstadoCivil() { Valor = EstadoCivil.Viuvo, Descricao = "Viúvo" },
            new ItemEstadoCivil() { Valor = EstadoCivil.Separado, Descricao = "Separado" },
            new ItemEstadoCivil() { Valor = EstadoCivil.UniaoEstavel, Descricao = "União Estável" }
        };
        private void CarregarEstadoCivil()
        {
            cmbEstadoCivil.DataSource = itemEstadoCivil;
            cmbEstadoCivil.DisplayMember = "Descricao";
            cmbEstadoCivil.ValueMember = "Valor";
        }
        private void CarregarGeneros()
        {
            cmbGenero.DataSource = itemGeneros;
            cmbGenero.DisplayMember = "Descricao";
            cmbGenero.ValueMember = "Valor";
        }

        public ClienteForm()
        {
            InitializeComponent();
            CarregarGeneros();
            CarregarEstadoCivil();
            _repository = new ClienteRepository();
            AtualizarGrid();
            CarregarCidades();
        }
        private void AtualizarGrid()
        {
            var clientes = _repository.ListarTodos();
            gridClientes.AutoGenerateColumns = false;
            gridClientes.DataSource = clientes;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtCep.Clear();
            txtLogradouro.Clear();
            txtBairro.Clear();
            txtUf.Clear();


            cmbGenero.SelectedIndex = -1;
            cmbEstadoCivil.SelectedIndex = -1;
            cmbCidade.SelectedIndex = -1;
            editingId = null;
            gridClientes.ClearSelection();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();

            tcCliente.SelectTab(tpClienteCadastro);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbGenero.SelectedItem == null || cmbEstadoCivil.SelectedItem == null)
            {
                MessageBox.Show("Preencha os campos (Genero) e ou (estado civil) antes de salvar.");
                return;
            }
            if (cmbCidade.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma cidade antes de salvar.");
                return;
            }

            ItemEstadoCivil estadoCivil = (ItemEstadoCivil)cmbEstadoCivil.SelectedItem;
            ItemGenero genero = (ItemGenero)cmbGenero.SelectedItem;
            Cidade cidade = (Cidade)cmbCidade.SelectedItem;
            var cliente = new Cliente()
            {
                Nome = txtNome.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Genero = genero.Valor,
                EstadoCivil = estadoCivil.Valor,
                Cep = txtCep.Text.Trim(),
                Logradouro = txtLogradouro.Text.Trim(),
                Bairro = txtBairro.Text.Trim(),
                Uf = txtUf.Text.Trim(),
                CidadeId = cidade.Id



            };
            if (editingId == null)
                _repository.Adicionar(cliente);
            else
            {
                cliente.Id = editingId.Value;
                _repository.Atualizar(cliente);
            }
            LimparCampos();
            AtualizarGrid();
            tcCliente.SelectTab(tpClienteConsulta);



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tcCliente.SelectTab(tpClienteConsulta);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (gridClientes.SelectedRows.Count == 0)
                return;
            if (MessageBox.Show("Excluir registro?", "Clientes",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var cliente = (Cliente)gridClientes.SelectedRows[0].DataBoundItem;
                _repository.Remover(cliente.Id);
                AtualizarGrid();
                tcCliente.SelectTab(tpClienteConsulta);
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (gridClientes.SelectedRows.Count == 0)
                return;

            var cliente = (Cliente)gridClientes.SelectedRows[0].DataBoundItem;
            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            txtCep.Text = cliente.Cep;
            txtLogradouro.Text = cliente.Logradouro;
            txtBairro.Text = cliente.Bairro;
            txtUf.Text = cliente.Uf;


            var cidade = _cidades.FirstOrDefault(c => c.Id == cliente.Id);
            cmbCidade.SelectedItem = cidade;
            txtUf.Text = cidade.Uf;

            cmbGenero.SelectedItem = itemGeneros.FirstOrDefault(g => g.Valor == cliente.Genero);
            cmbEstadoCivil.SelectedItem = itemEstadoCivil.FirstOrDefault(ec => ec.Valor == cliente.EstadoCivil);

            editingId = cliente.Id;
            tcCliente.SelectTab(tpClienteCadastro);
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

        private async void btnBuscarCep_Click(object sender, EventArgs e)
        {
            string cep = new string(txtCep.Text.Where(char.IsDigit).ToArray());

            if (cep.Length > 5)
                cep = cep.Insert(5, "-");

            txtCep.Text = cep;
            txtCep.SelectionStart = txtCep.Text.Length;

            if (string.IsNullOrEmpty(cep))
            {
                MessageBox.Show("Por favor, insira um CEP válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Endereco endereco = await BuscarCepAsync(cep);
                txtLogradouro.Text = endereco.Logradouro;
                txtBairro.Text = endereco.Bairro;
                cmbCidade.Text = endereco.Cidade;
                txtUf.Text = endereco.Uf;
                txtNumero.Focus();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Erro na requisição HTTP: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Desserializando o JSON: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarCidades()
        {
            var cidadeRepository = new CidadeRepository();
            _cidades = cidadeRepository.ListarTodos();
            cmbCidade.DataSource = _cidades;
            cmbCidade.DisplayMember = "Nome";
            cmbCidade.ValueMember = "Id";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var clientes = _repository.ObterPorNome(txtPesquisarNome.Text);
            gridClientes.AutoGenerateColumns = false;
            gridClientes.DataSource = clientes;

        }
    }
}
