namespace ControleClientes
{
    partial class ClienteForm
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
            tcCliente = new TabControl();
            tpClienteConsulta = new TabPage();
            pnlAcao = new Panel();
            btnNovo = new Button();
            btnVisualizar = new Button();
            gridClientes = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            pnlPesquisa = new Panel();
            txtPesquisarNome = new TextBox();
            btnPesquisar = new Button();
            tpClienteCadastro = new TabPage();
            lblGenero = new Label();
            cmbGenero = new ComboBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            cmbEstadoCivil = new ComboBox();
            lblEstadoCivil = new Label();
            tcCliente.SuspendLayout();
            tpClienteConsulta.SuspendLayout();
            pnlAcao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            pnlPesquisa.SuspendLayout();
            tpClienteCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tcCliente
            // 
            tcCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tcCliente.Controls.Add(tpClienteConsulta);
            tcCliente.Controls.Add(tpClienteCadastro);
            tcCliente.Location = new Point(-2, -22);
            tcCliente.Name = "tcCliente";
            tcCliente.SelectedIndex = 0;
            tcCliente.Size = new Size(624, 416);
            tcCliente.TabIndex = 0;
            // 
            // tpClienteConsulta
            // 
            tpClienteConsulta.Controls.Add(pnlAcao);
            tpClienteConsulta.Controls.Add(gridClientes);
            tpClienteConsulta.Controls.Add(pnlPesquisa);
            tpClienteConsulta.Location = new Point(4, 24);
            tpClienteConsulta.Name = "tpClienteConsulta";
            tpClienteConsulta.Padding = new Padding(3);
            tpClienteConsulta.Size = new Size(616, 388);
            tpClienteConsulta.TabIndex = 0;
            tpClienteConsulta.Text = "Consulta";
            tpClienteConsulta.UseVisualStyleBackColor = true;
            // 
            // pnlAcao
            // 
            pnlAcao.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnlAcao.Controls.Add(btnNovo);
            pnlAcao.Controls.Add(btnVisualizar);
            pnlAcao.Location = new Point(-1, 353);
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
            // gridClientes
            // 
            gridClientes.AllowUserToAddRows = false;
            gridClientes.AllowUserToDeleteRows = false;
            gridClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Columns.AddRange(new DataGridViewColumn[] { colId, colNome, colEmail });
            gridClientes.Location = new Point(3, 38);
            gridClientes.Name = "gridClientes";
            gridClientes.ReadOnly = true;
            gridClientes.Size = new Size(613, 315);
            gridClientes.TabIndex = 2;
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
            // colEmail
            // 
            colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEmail.DataPropertyName = "Email";
            colEmail.FillWeight = 50F;
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // pnlPesquisa
            // 
            pnlPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPesquisa.Controls.Add(txtPesquisarNome);
            pnlPesquisa.Controls.Add(btnPesquisar);
            pnlPesquisa.Location = new Point(0, 6);
            pnlPesquisa.Name = "pnlPesquisa";
            pnlPesquisa.Size = new Size(610, 28);
            pnlPesquisa.TabIndex = 5;
            // 
            // txtPesquisarNome
            // 
            txtPesquisarNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisarNome.Location = new Point(3, 3);
            txtPesquisarNome.Name = "txtPesquisarNome";
            txtPesquisarNome.PlaceholderText = "Pesquisar por nome";
            txtPesquisarNome.Size = new Size(492, 23);
            txtPesquisarNome.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.Image = Properties.Resources.search;
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.Location = new Point(499, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(104, 23);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "  &Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // tpClienteCadastro
            // 
            tpClienteCadastro.Controls.Add(lblEstadoCivil);
            tpClienteCadastro.Controls.Add(cmbEstadoCivil);
            tpClienteCadastro.Controls.Add(lblGenero);
            tpClienteCadastro.Controls.Add(cmbGenero);
            tpClienteCadastro.Controls.Add(btnCancelar);
            tpClienteCadastro.Controls.Add(btnSalvar);
            tpClienteCadastro.Controls.Add(btnExcluir);
            tpClienteCadastro.Controls.Add(txtEmail);
            tpClienteCadastro.Controls.Add(lblEmail);
            tpClienteCadastro.Controls.Add(txtNome);
            tpClienteCadastro.Controls.Add(lblNome);
            tpClienteCadastro.Location = new Point(4, 24);
            tpClienteCadastro.Name = "tpClienteCadastro";
            tpClienteCadastro.Padding = new Padding(3);
            tpClienteCadastro.Size = new Size(616, 388);
            tpClienteCadastro.TabIndex = 1;
            tpClienteCadastro.Text = "Cadastro";
            tpClienteCadastro.UseVisualStyleBackColor = true;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(434, 7);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(45, 15);
            lblGenero.TabIndex = 8;
            lblGenero.Text = "Genêro";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(434, 27);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(138, 23);
            cmbGenero.TabIndex = 7;
            cmbGenero.SelectedIndexChanged += cmbGenero_SelectedIndexChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Image = Properties.Resources.cross_circle;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(518, 353);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(89, 26);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "   &Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.Image = Properties.Resources.disk;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(420, 353);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(78, 26);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "   &Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExcluir.Image = Properties.Resources.trash_xmark;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(10, 356);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(78, 23);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "  &Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(19, 86);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(382, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(19, 68);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(18, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(383, 23);
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
            // cmbEstadoCivil
            // 
            cmbEstadoCivil.FormattingEnabled = true;
            cmbEstadoCivil.Location = new Point(434, 86);
            cmbEstadoCivil.Name = "cmbEstadoCivil";
            cmbEstadoCivil.Size = new Size(121, 23);
            cmbEstadoCivil.TabIndex = 9;
            cmbEstadoCivil.SelectedIndexChanged += cmbEstadoCivil_SelectedIndexChanged;
            // 
            // lblEstadoCivil
            // 
            lblEstadoCivil.AutoSize = true;
            lblEstadoCivil.Location = new Point(435, 65);
            lblEstadoCivil.Name = "lblEstadoCivil";
            lblEstadoCivil.Size = new Size(65, 15);
            lblEstadoCivil.TabIndex = 10;
            lblEstadoCivil.Text = "EstadoCivil";
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 393);
            Controls.Add(tcCliente);
            Name = "ClienteForm";
            Text = "ClienteForm";
            Load += ClienteForm_Load;
            tcCliente.ResumeLayout(false);
            tpClienteConsulta.ResumeLayout(false);
            pnlAcao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            pnlPesquisa.ResumeLayout(false);
            pnlPesquisa.PerformLayout();
            tpClienteCadastro.ResumeLayout(false);
            tpClienteCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcCliente;
        private TabPage tpClienteConsulta;
        private TabPage tpClienteCadastro;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtEmail;
        private Label lblEmail;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnExcluir;
        private DataGridView gridClientes;
        private Button btnVisualizar;
        private Button btnNovo;
        private Button btnPesquisar;
        private TextBox txtPesquisarNome;
        private Panel pnlAcao;
        private Panel pnlPesquisa;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colEmail;
        private ComboBox cmbGenero;
        private Label lblGenero;
        private Label lblEstadoCivil;
        private ComboBox cmbEstadoCivil;
    }
}