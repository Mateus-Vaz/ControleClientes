namespace ControleClientes
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem1 = new ToolStripMenuItem();
            janelaToolStripMenuItem = new ToolStripMenuItem();
            cascataToolStripMenuItem = new ToolStripMenuItem();
            ladoALadoHorizontalToolStripMenuItem = new ToolStripMenuItem();
            ladoALadoVerticalToolStripMenuItem = new ToolStripMenuItem();
            iconesMinimizadosToolStripMenuItem = new ToolStripMenuItem();
            cidadeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, janelaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(829, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem1, cidadeToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem1
            // 
            clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            clienteToolStripMenuItem1.Size = new Size(180, 22);
            clienteToolStripMenuItem1.Text = "Cliente";
            clienteToolStripMenuItem1.Click += clienteToolStripMenuItem1_Click;
            // 
            // janelaToolStripMenuItem
            // 
            janelaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascataToolStripMenuItem, ladoALadoHorizontalToolStripMenuItem, ladoALadoVerticalToolStripMenuItem, iconesMinimizadosToolStripMenuItem });
            janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            janelaToolStripMenuItem.Size = new Size(51, 20);
            janelaToolStripMenuItem.Text = "Janela";
            // 
            // cascataToolStripMenuItem
            // 
            cascataToolStripMenuItem.Name = "cascataToolStripMenuItem";
            cascataToolStripMenuItem.Size = new Size(191, 22);
            cascataToolStripMenuItem.Text = "Cascata";
            cascataToolStripMenuItem.Click += cascataToolStripMenuItem_Click;
            // 
            // ladoALadoHorizontalToolStripMenuItem
            // 
            ladoALadoHorizontalToolStripMenuItem.Name = "ladoALadoHorizontalToolStripMenuItem";
            ladoALadoHorizontalToolStripMenuItem.Size = new Size(191, 22);
            ladoALadoHorizontalToolStripMenuItem.Text = "Lado a lado horizontal";
            ladoALadoHorizontalToolStripMenuItem.Click += ladoALadoHorizontalToolStripMenuItem_Click;
            // 
            // ladoALadoVerticalToolStripMenuItem
            // 
            ladoALadoVerticalToolStripMenuItem.Name = "ladoALadoVerticalToolStripMenuItem";
            ladoALadoVerticalToolStripMenuItem.Size = new Size(191, 22);
            ladoALadoVerticalToolStripMenuItem.Text = "Lado a lado vertical";
            ladoALadoVerticalToolStripMenuItem.Click += ladoALadoVerticalToolStripMenuItem_Click;
            // 
            // iconesMinimizadosToolStripMenuItem
            // 
            iconesMinimizadosToolStripMenuItem.Name = "iconesMinimizadosToolStripMenuItem";
            iconesMinimizadosToolStripMenuItem.Size = new Size(191, 22);
            iconesMinimizadosToolStripMenuItem.Text = "Icones minimizados";
            iconesMinimizadosToolStripMenuItem.Click += iconesMinimizadosToolStripMenuItem_Click;
            // 
            // cidadeToolStripMenuItem
            // 
            cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            cidadeToolStripMenuItem.Size = new Size(180, 22);
            cidadeToolStripMenuItem.Text = "Cidade";
            cidadeToolStripMenuItem.Click += cidadeToolStripMenuItem_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 461);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuForm";
            Text = "Controle de Clientes";
            Load += MenuForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem1;
        private ToolStripMenuItem janelaToolStripMenuItem;
        private ToolStripMenuItem cascataToolStripMenuItem;
        private ToolStripMenuItem ladoALadoHorizontalToolStripMenuItem;
        private ToolStripMenuItem ladoALadoVerticalToolStripMenuItem;
        private ToolStripMenuItem iconesMinimizadosToolStripMenuItem;
        private ToolStripMenuItem cidadeToolStripMenuItem;
    }
}
