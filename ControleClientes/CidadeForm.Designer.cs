
namespace ControleClientes
{
    partial class CidadeForm
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
            tcCidade = new TabControl();
            tpCidadeConsulta = new TabPage();
            gridCidades = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            pnlAcao = new Panel();
            btnNovo = new Button();
            btnVisualizar = new Button();
            pnlPesquisa = new Panel();
            txtPesquisarNome = new TextBox();
            btnPesquisar = new Button();
            tpCidadeCadastro = new TabPage();
            lblUf = new Label();
            txtUf = new TextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            txtNome = new TextBox();
            lblNome = new Label();
            tcCidade.SuspendLayout();
            tpCidadeConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCidades).BeginInit();
            pnlAcao.SuspendLayout();
            pnlPesquisa.SuspendLayout();
            tpCidadeCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tcCidade
            // 
            tcCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tcCidade.Controls.Add(tpCidadeConsulta);
            tcCidade.Controls.Add(tpCidadeCadastro);
            tcCidade.Location = new Point(-2, -22);
            tcCidade.Name = "tcCidade";
            tcCidade.SelectedIndex = 0;
            tcCidade.Size = new Size(624, 416);
            tcCidade.TabIndex = 0;
            // 
            // tpCidadeConsulta
            // 
            tpCidadeConsulta.Controls.Add(gridCidades);
            tpCidadeConsulta.Controls.Add(pnlAcao);
            tpCidadeConsulta.Controls.Add(pnlPesquisa);
            tpCidadeConsulta.Location = new Point(4, 24);
            tpCidadeConsulta.Name = "tpCidadeConsulta";
            tpCidadeConsulta.Padding = new Padding(3);
            tpCidadeConsulta.Size = new Size(616, 388);
            tpCidadeConsulta.TabIndex = 0;
            tpCidadeConsulta.Text = "Consulta";
            tpCidadeConsulta.UseVisualStyleBackColor = true;
            // 
            // gridCidades
            // 
            gridCidades.AllowUserToAddRows = false;
            gridCidades.AllowUserToDeleteRows = false;
            gridCidades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridCidades.BackgroundColor = SystemColors.GradientActiveCaption;
            gridCidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCidades.Columns.AddRange(new DataGridViewColumn[] { colId, colNome, colEmail });
            gridCidades.GridColor = Color.AliceBlue;
            gridCidades.Location = new Point(0, 35);
            gridCidades.Name = "gridCidades";
            gridCidades.ReadOnly = true;
            gridCidades.Size = new Size(611, 315);
            gridCidades.TabIndex = 2;
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
            // pnlAcao
            // 
            pnlAcao.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnlAcao.BackColor = Color.White;
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
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // tpCidadeCadastro
            // 
            tpCidadeCadastro.BackColor = Color.LightSteelBlue;
            tpCidadeCadastro.Controls.Add(lblUf);
            tpCidadeCadastro.Controls.Add(txtUf);
            tpCidadeCadastro.Controls.Add(btnCancelar);
            tpCidadeCadastro.Controls.Add(btnSalvar);
            tpCidadeCadastro.Controls.Add(btnExcluir);
            tpCidadeCadastro.Controls.Add(txtNome);
            tpCidadeCadastro.Controls.Add(lblNome);
            tpCidadeCadastro.Location = new Point(4, 24);
            tpCidadeCadastro.Name = "tpCidadeCadastro";
            tpCidadeCadastro.Padding = new Padding(3);
            tpCidadeCadastro.Size = new Size(616, 388);
            tpCidadeCadastro.TabIndex = 1;
            tpCidadeCadastro.Text = "Cadastro";
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(15, 73);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(19, 15);
            lblUf.TabIndex = 26;
            lblUf.Text = "Uf";
            // 
            // txtUf
            // 
            txtUf.BackColor = SystemColors.InactiveCaption;
            txtUf.Location = new Point(18, 103);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(169, 23);
            txtUf.TabIndex = 19;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.Ivory;
            btnCancelar.Image = Properties.Resources.cross_circle;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(518, 353);
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
            btnSalvar.Location = new Point(420, 353);
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
            btnExcluir.Location = new Point(10, 356);
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
            // CidadeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(621, 393);
            Controls.Add(tcCidade);
            Name = "CidadeForm";
            Text = "CidadeForm";
            Load += CidadeForm_Load;
            tcCidade.ResumeLayout(false);
            tpCidadeConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridCidades).EndInit();
            pnlAcao.ResumeLayout(false);
            pnlPesquisa.ResumeLayout(false);
            pnlPesquisa.PerformLayout();
            tpCidadeCadastro.ResumeLayout(false);
            tpCidadeCadastro.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private TabControl tcCidade;
        private TabPage tpCidadeConsulta;
        private TabPage tpCidadeCadastro;
        private TextBox txtNome;
        private Label lblNome;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnExcluir;
        private DataGridView gridCidades;
        private Button btnVisualizar;
        private Button btnNovo;
        private Button btnPesquisar;
        private TextBox txtPesquisarNome;
        private Panel pnlAcao;
        private Panel pnlPesquisa;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colEmail;
        private TextBox txtUf;
        private Label lblUf;
    }
}