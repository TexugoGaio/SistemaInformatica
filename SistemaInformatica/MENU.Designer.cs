namespace SistemaInformatica
{
    partial class MENU
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
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.gpbVenda = new System.Windows.Forms.GroupBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.gpbCadastros = new System.Windows.Forms.GroupBox();
            this.btnRelProd = new System.Windows.Forms.Button();
            this.btnRelCli = new System.Windows.Forms.Button();
            this.gpbConsulta = new System.Windows.Forms.GroupBox();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.gpbProduto = new System.Windows.Forms.GroupBox();
            this.btnBuscaProd = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.rdbCodProd = new System.Windows.Forms.RadioButton();
            this.lblProduto = new System.Windows.Forms.Label();
            this.rdbMarca = new System.Windows.Forms.RadioButton();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscaCli = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbCodCli = new System.Windows.Forms.RadioButton();
            this.gpbVenda.SuspendLayout();
            this.gpbCadastros.SuspendLayout();
            this.gpbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.gpbProduto.SuspendLayout();
            this.gpbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(30, 29);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(149, 88);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "&CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(191, 29);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(149, 88);
            this.btnProdutos.TabIndex = 1;
            this.btnProdutos.Text = "&PRODUTOS";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Location = new System.Drawing.Point(31, 30);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(149, 88);
            this.btnNovaVenda.TabIndex = 2;
            this.btnNovaVenda.Text = "&NOVA VENDA";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // gpbVenda
            // 
            this.gpbVenda.BackColor = System.Drawing.Color.Salmon;
            this.gpbVenda.Controls.Add(this.btnRelatorio);
            this.gpbVenda.Controls.Add(this.btnNovaVenda);
            this.gpbVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbVenda.Location = new System.Drawing.Point(112, 67);
            this.gpbVenda.Name = "gpbVenda";
            this.gpbVenda.Size = new System.Drawing.Size(395, 144);
            this.gpbVenda.TabIndex = 3;
            this.gpbVenda.TabStop = false;
            this.gpbVenda.Text = "VENDAS";
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(215, 28);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(149, 88);
            this.btnRelatorio.TabIndex = 3;
            this.btnRelatorio.Text = "RELATÓRIO VENDAS";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // gpbCadastros
            // 
            this.gpbCadastros.BackColor = System.Drawing.Color.Salmon;
            this.gpbCadastros.Controls.Add(this.btnRelProd);
            this.gpbCadastros.Controls.Add(this.btnRelCli);
            this.gpbCadastros.Controls.Add(this.btnClientes);
            this.gpbCadastros.Controls.Add(this.btnProdutos);
            this.gpbCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCadastros.Location = new System.Drawing.Point(538, 67);
            this.gpbCadastros.Name = "gpbCadastros";
            this.gpbCadastros.Size = new System.Drawing.Size(704, 145);
            this.gpbCadastros.TabIndex = 4;
            this.gpbCadastros.TabStop = false;
            this.gpbCadastros.Text = "CADASTROS";
            // 
            // btnRelProd
            // 
            this.btnRelProd.Location = new System.Drawing.Point(524, 28);
            this.btnRelProd.Name = "btnRelProd";
            this.btnRelProd.Size = new System.Drawing.Size(149, 88);
            this.btnRelProd.TabIndex = 3;
            this.btnRelProd.Text = "RELATÓRIO PRODUTOS";
            this.btnRelProd.UseVisualStyleBackColor = true;
            this.btnRelProd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRelCli
            // 
            this.btnRelCli.Location = new System.Drawing.Point(356, 28);
            this.btnRelCli.Name = "btnRelCli";
            this.btnRelCli.Size = new System.Drawing.Size(149, 88);
            this.btnRelCli.TabIndex = 2;
            this.btnRelCli.Text = "RELATÓRIO CLIENTES";
            this.btnRelCli.UseVisualStyleBackColor = true;
            // 
            // gpbConsulta
            // 
            this.gpbConsulta.BackColor = System.Drawing.Color.MistyRose;
            this.gpbConsulta.Controls.Add(this.dgvMenu);
            this.gpbConsulta.Controls.Add(this.gpbProduto);
            this.gpbConsulta.Controls.Add(this.gpbCliente);
            this.gpbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbConsulta.Location = new System.Drawing.Point(112, 284);
            this.gpbConsulta.Name = "gpbConsulta";
            this.gpbConsulta.Size = new System.Drawing.Size(1130, 413);
            this.gpbConsulta.TabIndex = 4;
            this.gpbConsulta.TabStop = false;
            this.gpbConsulta.Text = "CONSULTAR";
            this.gpbConsulta.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(101, 257);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(974, 150);
            this.dgvMenu.TabIndex = 6;
            // 
            // gpbProduto
            // 
            this.gpbProduto.BackColor = System.Drawing.SystemColors.Control;
            this.gpbProduto.Controls.Add(this.btnBuscaProd);
            this.gpbProduto.Controls.Add(this.txtProduto);
            this.gpbProduto.Controls.Add(this.rdbCodProd);
            this.gpbProduto.Controls.Add(this.lblProduto);
            this.gpbProduto.Controls.Add(this.rdbMarca);
            this.gpbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProduto.Location = new System.Drawing.Point(617, 45);
            this.gpbProduto.Name = "gpbProduto";
            this.gpbProduto.Size = new System.Drawing.Size(458, 197);
            this.gpbProduto.TabIndex = 5;
            this.gpbProduto.TabStop = false;
            this.gpbProduto.Text = "PRODUTOS";
            // 
            // btnBuscaProd
            // 
            this.btnBuscaProd.Location = new System.Drawing.Point(333, 95);
            this.btnBuscaProd.Name = "btnBuscaProd";
            this.btnBuscaProd.Size = new System.Drawing.Size(103, 73);
            this.btnBuscaProd.TabIndex = 6;
            this.btnBuscaProd.Text = "BUSCAR";
            this.btnBuscaProd.UseVisualStyleBackColor = true;
            this.btnBuscaProd.Click += new System.EventHandler(this.btnBuscaProd_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(35, 139);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(279, 29);
            this.txtProduto.TabIndex = 8;
            // 
            // rdbCodProd
            // 
            this.rdbCodProd.AutoSize = true;
            this.rdbCodProd.Location = new System.Drawing.Point(75, 43);
            this.rdbCodProd.Name = "rdbCodProd";
            this.rdbCodProd.Size = new System.Drawing.Size(108, 28);
            this.rdbCodProd.TabIndex = 5;
            this.rdbCodProd.TabStop = true;
            this.rdbCodProd.Text = "CODIGO";
            this.rdbCodProd.UseVisualStyleBackColor = true;
            this.rdbCodProd.CheckedChanged += new System.EventHandler(this.rbdCodProd_CheckedChanged);
            // 
            // lblProduto
            // 
            this.lblProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProduto.Location = new System.Drawing.Point(35, 95);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(279, 29);
            this.lblProduto.TabIndex = 7;
            // 
            // rdbMarca
            // 
            this.rdbMarca.AutoSize = true;
            this.rdbMarca.Location = new System.Drawing.Point(261, 43);
            this.rdbMarca.Name = "rdbMarca";
            this.rdbMarca.Size = new System.Drawing.Size(101, 28);
            this.rdbMarca.TabIndex = 6;
            this.rdbMarca.TabStop = true;
            this.rdbMarca.Text = "MARCA";
            this.rdbMarca.UseVisualStyleBackColor = true;
            this.rdbMarca.CheckedChanged += new System.EventHandler(this.rdbMarca_CheckedChanged);
            // 
            // gpbCliente
            // 
            this.gpbCliente.BackColor = System.Drawing.SystemColors.Control;
            this.gpbCliente.Controls.Add(this.btnBuscaCli);
            this.gpbCliente.Controls.Add(this.txtCliente);
            this.gpbCliente.Controls.Add(this.lblCliente);
            this.gpbCliente.Controls.Add(this.rdbNome);
            this.gpbCliente.Controls.Add(this.rdbCodCli);
            this.gpbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCliente.Location = new System.Drawing.Point(101, 45);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(445, 197);
            this.gpbCliente.TabIndex = 4;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "CLIENTES";
            // 
            // btnBuscaCli
            // 
            this.btnBuscaCli.Location = new System.Drawing.Point(325, 95);
            this.btnBuscaCli.Name = "btnBuscaCli";
            this.btnBuscaCli.Size = new System.Drawing.Size(103, 73);
            this.btnBuscaCli.TabIndex = 5;
            this.btnBuscaCli.Text = "BUSCAR";
            this.btnBuscaCli.UseVisualStyleBackColor = true;
            this.btnBuscaCli.Click += new System.EventHandler(this.btnBuscaCli_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(39, 139);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(271, 29);
            this.txtCliente.TabIndex = 4;
            // 
            // lblCliente
            // 
            this.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCliente.Location = new System.Drawing.Point(39, 95);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(271, 29);
            this.lblCliente.TabIndex = 3;
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(255, 43);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(90, 28);
            this.rdbNome.TabIndex = 2;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "NOME";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.rdbNome_CheckedChanged);
            // 
            // rdbCodCli
            // 
            this.rdbCodCli.AutoSize = true;
            this.rdbCodCli.Location = new System.Drawing.Point(69, 43);
            this.rdbCodCli.Name = "rdbCodCli";
            this.rdbCodCli.Size = new System.Drawing.Size(108, 28);
            this.rdbCodCli.TabIndex = 1;
            this.rdbCodCli.TabStop = true;
            this.rdbCodCli.Text = "CODIGO";
            this.rdbCodCli.UseVisualStyleBackColor = true;
            this.rdbCodCli.CheckedChanged += new System.EventHandler(this.rdbCodCli_CheckedChanged);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1314, 733);
            this.Controls.Add(this.gpbConsulta);
            this.Controls.Add(this.gpbCadastros);
            this.Controls.Add(this.gpbVenda);
            this.Name = "MENU";
            this.Text = "MENU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gpbVenda.ResumeLayout(false);
            this.gpbCadastros.ResumeLayout(false);
            this.gpbConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.gpbProduto.ResumeLayout(false);
            this.gpbProduto.PerformLayout();
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.GroupBox gpbVenda;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.GroupBox gpbCadastros;
        private System.Windows.Forms.GroupBox gpbConsulta;
        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.GroupBox gpbProduto;
        private System.Windows.Forms.Button btnRelCli;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbCodCli;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.RadioButton rdbCodProd;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.RadioButton rdbMarca;
        private System.Windows.Forms.Button btnBuscaProd;
        private System.Windows.Forms.Button btnBuscaCli;
        private System.Windows.Forms.Button btnRelProd;
    }
}