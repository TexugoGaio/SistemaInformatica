using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInformatica
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCliente frmCli = new frmCliente();
            //frmCli.MdiParent = this;
            frmCli.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmProduto frmProd = new frmProduto();
            frmProd.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            lblCliente.Text = "Informe o Nome";
            txtCliente.Text = "";
            txtCliente.Focus();
            lblProduto.Text = "";
            rdbCodProd.Checked = false;
            rdbMarca.Checked = false;
            lblProduto.Enabled = false;
            txtProduto.Enabled = false;
            lblCliente.Enabled = true;
            txtCliente.Enabled = true;
            btnBuscaCli.Enabled = true;
            
        }

        private void rdbCodCli_CheckedChanged(object sender, EventArgs e)
        {
            lblCliente.Text = "Informe o ID";
            txtCliente.Text = "";
            txtCliente.Focus();
            lblProduto.Text = "";
            rdbCodProd.Checked = false;
            rdbMarca.Checked = false;
            lblProduto.Enabled = false;
            txtProduto.Enabled = false;
            btnBuscaProd.Enabled = false;
            lblCliente.Enabled = true;
            txtCliente.Enabled = true;
            btnBuscaCli.Enabled = true;
            
        }

        private void rbdCodProd_CheckedChanged(object sender, EventArgs e)
        {
            lblProduto.Text = "Informe o ID";
            txtProduto.Text = "";
            txtCliente.Focus();
            lblCliente.Text = "";
            rdbCodCli.Checked = false;
            rdbNome.Checked = false;
            lblCliente.Enabled = false;
            txtCliente.Enabled = false;
            btnBuscaCli.Enabled = false;
            lblProduto.Enabled = true;
            txtProduto.Enabled = true;
            btnBuscaProd.Enabled = true;
            

        }

        private void rdbMarca_CheckedChanged(object sender, EventArgs e)
        {
            lblProduto.Text = "Informe a Marca";
            txtProduto.Text = "";
            txtProduto.Focus();
            lblCliente.Text = "";
            rdbCodCli.Checked = false;
            rdbNome.Checked = false;
            lblCliente.Enabled = false;
            txtCliente.Enabled = false;
            btnBuscaCli.Enabled = false;
            lblProduto.Enabled = true;
            txtProduto.Enabled = true;
            btnBuscaProd.Enabled = true;
        }

        private void btnBuscaCli_Click(object sender, EventArgs e)
        {
            if(txtCliente.Text != string.Empty)
            {
                CAMADAS.BLL.Cliente bllCli = new CAMADAS.BLL.Cliente();
                List<CAMADAS.MODEL.Cliente> lstCliente = new List<CAMADAS.MODEL.Cliente>();

                if (rdbCodCli.Checked)
                    lstCliente = bllCli.SelectById(Convert.ToInt32(txtCliente.Text));
                else if (rdbNome.Checked)
                    lstCliente = bllCli.SelectByNome(txtCliente.Text);

                dgvMenu.DataSource = "";
                dgvMenu.DataSource = lstCliente;

            }
            else
            {
                string msg = "Campo de pesquisa vazio.";
                MessageBox.Show(msg, "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnBuscaProd_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text != string.Empty)
            {
                CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto();
                List<CAMADAS.MODEL.Produto> lstProduto = new List<CAMADAS.MODEL.Produto>();

                if (rdbCodProd.Checked)
                    lstProduto = bllProd.SelectById(Convert.ToInt32(txtProduto.Text));
                else if (rdbMarca.Checked)
                    lstProduto = bllProd.SelectByMarca(txtProduto.Text);

                dgvMenu.DataSource = "";
                dgvMenu.DataSource = lstProduto;

            }
            else
            {
                string msg = "Campo de pesquisa vazio.";
                MessageBox.Show(msg, "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            frmVenda frm = new frmVenda();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CAMADAS.Relatórios.RelProdutos.impRelProd();
        }

        private void btnRelCli_Click(object sender, EventArgs e)
        {
            CAMADAS.Relatórios.RelClientes.impRelCli();
        }
    }
}
