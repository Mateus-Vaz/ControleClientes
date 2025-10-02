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
        public ClienteForm()
        {
            InitializeComponent();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {


        }      

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tcCliente.SelectTab(tpClienteCadastro);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tcCliente.SelectTab(tpClienteConsulta);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tcCliente.SelectTab(tpClienteConsulta);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Excluir registro"," clientes", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tcCliente.SelectTab(tpClienteConsulta);
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            tcCliente.SelectTab(tpClienteCadastro);
        }
    }
}
