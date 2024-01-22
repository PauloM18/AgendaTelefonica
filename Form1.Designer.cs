namespace ProjetoFinal
{
    partial class frmAgendaContato
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
            lbxContatos = new ListBox();
            lbNome = new Label();
            txbNome = new TextBox();
            txbEmail = new TextBox();
            txbTelefone = new TextBox();
            lbEmail = new Label();
            lbTelefone = new Label();
            btnIncluir = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lbxContatos
            // 
            lbxContatos.FormattingEnabled = true;
            lbxContatos.ItemHeight = 15;
            lbxContatos.Location = new Point(12, 12);
            lbxContatos.Name = "lbxContatos";
            lbxContatos.Size = new Size(217, 244);
            lbxContatos.TabIndex = 0;
            lbxContatos.SelectedIndexChanged += lbxContatos_SelectedIndexChanged;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(235, 22);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(46, 15);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome: ";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(287, 19);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(259, 23);
            txbNome.TabIndex = 2;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(287, 59);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(259, 23);
            txbEmail.TabIndex = 3;
            // 
            // txbTelefone
            // 
            txbTelefone.Location = new Point(287, 99);
            txbTelefone.Name = "txbTelefone";
            txbTelefone.Size = new Size(259, 23);
            txbTelefone.TabIndex = 4;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(235, 62);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(42, 15);
            lbEmail.TabIndex = 5;
            lbEmail.Text = "Email: ";
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Location = new Point(235, 102);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(24, 15);
            lbTelefone.TabIndex = 6;
            lbTelefone.Text = "Tel:";
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(235, 138);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(75, 23);
            btnIncluir.TabIndex = 7;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(316, 138);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(397, 138);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(235, 167);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(316, 167);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmAgendaContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 273);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnIncluir);
            Controls.Add(lbTelefone);
            Controls.Add(lbEmail);
            Controls.Add(txbTelefone);
            Controls.Add(txbEmail);
            Controls.Add(txbNome);
            Controls.Add(lbNome);
            Controls.Add(lbxContatos);
            Name = "frmAgendaContato";
            Text = "TreinaWeb - Agenda de Contatos";
            Load += frmAgendaContato_Load;
            Shown += frmAgendaContato_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxContatos;
        private Label lbNome;
        private TextBox txbNome;
        private TextBox txbEmail;
        private TextBox txbTelefone;
        private Label lbEmail;
        private Label lbTelefone;
        private Button btnIncluir;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}
