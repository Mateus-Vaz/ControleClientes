using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleClientes
{
    public partial class ClienteForm : Form
    {
        private readonly ClienteRepository _repository;
        private int? editingId = null;

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
        }
        private void AtualizarGrid()
        {
            var clientes = _repository.ListarTodos();
            gridClientes.DataSource = clientes;
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {


        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            cmbGenero.SelectedIndex = -1;
            cmbEstadoCivil.SelectedIndex = -1;
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
            ItemEstadoCivil estadoCivil = (ItemEstadoCivil)cmbEstadoCivil.SelectedItem;
            ItemGenero genero = (ItemGenero)cmbGenero.SelectedItem;
            var cliente = new Cliente()
            {
                Nome = txtNome.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Genero = genero.Valor,
                EstadoCivil =  estadoCivil.Valor
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
            cmbGenero.SelectedItem = itemGeneros.FirstOrDefault(g => g.Valor == cliente.Genero);
            cmbEstadoCivil.SelectedItem = itemEstadoCivil.FirstOrDefault(ec => ec.Valor == cliente.EstadoCivil);
            editingId = cliente.Id;
            tcCliente.SelectTab(tpClienteCadastro);
        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

