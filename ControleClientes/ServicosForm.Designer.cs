
namespace ControleClientes
{
    partial class ServicoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tcServico = new TabControl();
            tpServicoConsulta = new TabPage();
            gridServicos = new DataGridView();
            pnlAcao = new Panel();
            btnNovo = new Button();
            btnVisualizar = new Button();
            pnlPesquisa = new Panel();
            txtPesquisarNome = new TextBox();
            btnPesquisar = new Button();
            tpServicoCadastro = new TabPage();
            lblPreco = new Label();
            lblCategoria = new Label();
            txtPreco = new TextBox();
            txtCategoria = new TextBox();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            txtNome = new TextBox();
            lblNome = new Label();
            colId = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colDescricao = new DataGridViewTextBoxColumn();
            tcServico.SuspendLayout();
            tpServicoConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridServicos).BeginInit();
            pnlAcao.SuspendLayout();
            pnlPesquisa.SuspendLayout();
            tpServicoCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tcServico
            // 
            tcServico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tcServico.Controls.Add(tpServicoConsulta);
            tcServico.Controls.Add(tpServicoCadastro);
            tcServico.Location = new Point(-2, -22);
            tcServico.Name = "tcServico";
            tcServico.SelectedIndex = 0;
            tcServico.Size = new Size(744, 474);
            tcServico.TabIndex = 0;
            // 
            // tpServicoConsulta
            // 
            tpServicoConsulta.Controls.Add(gridServicos);
            tpServicoConsulta.Controls.Add(pnlAcao);
            tpServicoConsulta.Controls.Add(pnlPesquisa);
            tpServicoConsulta.Location = new Point(4, 24);
            tpServicoConsulta.Name = "tpServicoConsulta";
            tpServicoConsulta.Padding = new Padding(3);
            tpServicoConsulta.Size = new Size(736, 446);
            tpServicoConsulta.TabIndex = 0;
            tpServicoConsulta.Text = "Consulta";
            tpServicoConsulta.UseVisualStyleBackColor = true;
            // 
            // gridServicos
            // 
            gridServicos.AllowUserToAddRows = false;
            gridServicos.AllowUserToDeleteRows = false;
            gridServicos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridServicos.BackgroundColor = SystemColors.GradientActiveCaption;
            gridServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridServicos.Columns.AddRange(new DataGridViewColumn[] { colId, colNome, colDescricao });
            gridServicos.GridColor = Color.AliceBlue;
            gridServicos.Location = new Point(0, 38);
            gridServicos.Name = "gridServicos";
            gridServicos.ReadOnly = true;
            gridServicos.Size = new Size(731, 370);
            gridServicos.TabIndex = 2;
            // 
            // pnlAcao
            // 
            pnlAcao.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnlAcao.BackColor = Color.White;
            pnlAcao.Controls.Add(btnNovo);
            pnlAcao.Controls.Add(btnVisualizar);
            pnlAcao.Location = new Point(119, 411);
            pnlAcao.Name = "pnlAcao";
            pnlAcao.Size = new Size(614, 32);
            pnlAcao.TabIndex = 5;
            // 
            // btnNovo
            // 
            btnNovo.Image = Properties.Resources.add_document;
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.Location = new Point(446, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(74, 26);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "  &Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Image = Properties.Resources.magnifying_glass_eye;
            btnVisualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVisualizar.Location = new Point(526, 3);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(85, 26);
            btnVisualizar.TabIndex = 1;
            btnVisualizar.Text = "  &Visualizar";
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // pnlPesquisa
            // 
            pnlPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPesquisa.Controls.Add(txtPesquisarNome);
            pnlPesquisa.Controls.Add(btnPesquisar);
            pnlPesquisa.Location = new Point(0, 6);
            pnlPesquisa.Name = "pnlPesquisa";
            pnlPesquisa.Size = new Size(730, 28);
            pnlPesquisa.TabIndex = 5;
            // 
            // txtPesquisarNome
            // 
            txtPesquisarNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisarNome.Location = new Point(3, 3);
            txtPesquisarNome.Name = "txtPesquisarNome";
            txtPesquisarNome.PlaceholderText = "Pesquisar por nome";
            txtPesquisarNome.Size = new Size(612, 23);
            txtPesquisarNome.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.Image = Properties.Resources.search;
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.Location = new Point(619, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(104, 23);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "  &Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // tpServicoCadastro
            // 
            tpServicoCadastro.BackColor = Color.LightSteelBlue;
            tpServicoCadastro.Controls.Add(lblPreco);
            tpServicoCadastro.Controls.Add(lblCategoria);
            tpServicoCadastro.Controls.Add(txtPreco);
            tpServicoCadastro.Controls.Add(txtCategoria);
            tpServicoCadastro.Controls.Add(lblDescricao);
            tpServicoCadastro.Controls.Add(txtDescricao);
            tpServicoCadastro.Controls.Add(btnCancelar);
            tpServicoCadastro.Controls.Add(btnSalvar);
            tpServicoCadastro.Controls.Add(btnExcluir);
            tpServicoCadastro.Controls.Add(txtNome);
            tpServicoCadastro.Controls.Add(lblNome);
            tpServicoCadastro.Location = new Point(4, 24);
            tpServicoCadastro.Name = "tpServicoCadastro";
            tpServicoCadastro.Padding = new Padding(3);
            tpServicoCadastro.Size = new Size(736, 446);
            tpServicoCadastro.TabIndex = 1;
            tpServicoCadastro.Text = "Cadastro";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(15, 198);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 30;
            lblPreco.Text = "Preço";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(15, 128);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 29;
            lblCategoria.Text = "Categoria";
            // 
            // txtPreco
            // 
            txtPreco.BackColor = SystemColors.InactiveCaption;
            txtPreco.Location = new Point(15, 226);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 28;
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = SystemColors.InactiveCaption;
            txtCategoria.Location = new Point(15, 157);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(155, 23);
            txtCategoria.TabIndex = 27;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(15, 64);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 26;
            lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = SystemColors.InactiveCaption;
            txtDescricao.Location = new Point(15, 91);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(319, 23);
            txtDescricao.TabIndex = 19;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.Ivory;
            btnCancelar.Image = Properties.Resources.cross_circle;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(638, 411);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(89, 26);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "   &Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.BackColor = Color.Honeydew;
            btnSalvar.Image = Properties.Resources.disk;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(554, 411);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(78, 26);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "   &Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExcluir.BackColor = Color.LightCoral;
            btnExcluir.Image = Properties.Resources.trash_xmark;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(10, 413);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(78, 23);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "  &Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.InactiveCaption;
            txtNome.Location = new Point(18, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(319, 23);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(15, 8);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 42;
            // 
            // colNome
            // 
            colNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNome.DataPropertyName = "Nome";
            colNome.FillWeight = 50F;
            colNome.HeaderText = "Nome";
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            // 
            // colDescricao
            // 
            colDescricao.DataPropertyName = "Descrição";
            colDescricao.HeaderText = "Descrição";
            colDescricao.Name = "colDescricao";
            colDescricao.ReadOnly = true;
            // 
            // ServicoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(741, 451);
            Controls.Add(tcServico);
            Name = "ServicoForm";
            Text = "ServicoForm";
            tcServico.ResumeLayout(false);
            tpServicoConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridServicos).EndInit();
            pnlAcao.ResumeLayout(false);
            pnlPesquisa.ResumeLayout(false);
            pnlPesquisa.PerformLayout();
            tpServicoCadastro.ResumeLayout(false);
            tpServicoCadastro.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private TabControl tcServico;
        private TabPage tpServicoConsulta;
        private TabPage tpServicoCadastro;
        private TextBox txtNome;
        private Label lblNome;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnExcluir;
        private DataGridView gridServicos;
        private Button btnVisualizar;
        private Button btnNovo;
        private Button btnPesquisar;
        private TextBox txtPesquisarNome;
        private Panel pnlAcao;
        private Panel pnlPesquisa;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private Label lblCategoria;
        private TextBox txtPreco;
        private TextBox txtCategoria;
        private Label lblPreco;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colDescricao;
    }
}