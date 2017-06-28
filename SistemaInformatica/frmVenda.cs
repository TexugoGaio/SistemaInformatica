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
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }
        CAMADAS.MODEL.Produto produto = new CAMADAS.MODEL.Produto();

        private void Habilitar(bool status)
        {
            txtCodCli.Enabled = status;
            dtpVenda.Enabled = status;
            txtCodProd.Enabled = status;
            txtQtd.Enabled = status;
            txtValorUni.Enabled = false;
            txtValorTotal.Enabled = false;
            cmbCliente.Enabled = status;
            cmbProduto.Enabled = status;
            btnAdd.Enabled = status;
            btnCancelar.Enabled = status;
            btnFinalizar.Enabled = status;
            btnInserir.Enabled = !status;
            btnSelectCli.Enabled = status;
        }

        private void Limpar()
        {
            txtCodCli.Text = "";
            txtCodProd.Text = "";
            txtCodVenda.Text = "";
            txtQtd.Text = "";
            txtValorTotal.Text = "";
            txtValorUni.Text = "";
            
        }

        private void RecuperaDadosProduto()
        {
            CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto();
            List<CAMADAS.MODEL.Produto> lstProd = new List<CAMADAS.MODEL.Produto>();
            lstProd = bllProd.SelectById(Convert.ToInt32(txtCodProd.Text));
            if (lstProd != null)
                produto = lstProd[0];
            else MessageBox.Show("Produto não encontrado");
            if(produto.estoque < 1)
            {
                MessageBox.Show("Produto sem estoque!");
                cmbProduto.Focus();
            }
            else
            {
                txtValorUni.Text = produto.valor.ToString();
            }
        }

        private void lblValorTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblQtd_Click(object sender, EventArgs e)
        {

        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            Habilitar(false);
            Limpar();
            CAMADAS.BLL.Venda bllvenda = new CAMADAS.BLL.Venda();

            dgvCli.DataSource = bllvenda.Select();

            //carregar ComboBox Cliente
            CAMADAS.BLL.Cliente bllCliente = new CAMADAS.BLL.Cliente();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "idCli";
            cmbCliente.DataSource = bllCliente.Select();

            //carregar Combobox Produto
            CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto();
            cmbProduto.DisplayMember = "descricao";
            cmbProduto.ValueMember = "idProd";
            cmbProduto.DataSource = bllProd.Select();
            
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Limpar();
            Habilitar(true);
            txtCodVenda.Text = "-1";
            dtpVenda.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.ItemVenda bllItem = new CAMADAS.BLL.ItemVenda();
            CAMADAS.MODEL.ItemVenda itemVenda = new CAMADAS.MODEL.ItemVenda();
            int id = -1;

            string msg = "Confirma inclusão do Produto?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Inserir", MessageBoxButtons.YesNo);
            if(resp == DialogResult.Yes)
            {
                itemVenda.idItem = id;
                itemVenda.idVenda = Convert.ToInt32(txtCodVenda.Text);
                itemVenda.idProd = Convert.ToInt32(txtCodProd.Text);
                itemVenda.valor = Convert.ToSingle(txtValorUni.Text);
                itemVenda.quantidade = Convert.ToInt32(txtQtd.Text);

                bllItem.Insert(itemVenda);
            }
            dgvProd.DataSource = "";
            dgvProd.DataSource = bllItem.SelectByVenda(Convert.ToInt32(txtCodVenda.Text));
            Limpar();

           
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodProd.Text = cmbProduto.SelectedValue.ToString();
            RecuperaDadosProduto();
        }

        private void dgvProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodCli.Text = cmbCliente.SelectedValue.ToString();
        }

        private void dgvCli_DoubleClick(object sender, EventArgs e)
        {
            if(dgvCli.SelectedRows.Count > 0)
            {
                txtCodVenda.Text = dgvCli.SelectedRows[0].Cells["idVenda"].Value.ToString();
                txtCodCli.Text = dgvCli.SelectedRows[0].Cells["idCli"].Value.ToString();
                cmbCliente.SelectedValue = Convert.ToInt32(txtCodCli.Text);
                dtpVenda.Value = Convert.ToDateTime(dgvCli.SelectedRows[0].Cells["dataVenda"].Value.ToString());

                //atualizar gridview itemProduto
                CAMADAS.BLL.ItemVenda bllItem = new CAMADAS.BLL.ItemVenda();
                int idVenda = Convert.ToInt32(txtCodVenda.Text);
                dgvCli.DataSource = "";
                dgvCli.DataSource = bllItem.SelectByVenda(idVenda);
            }
        }

        private void btnSelectCli_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Venda bllVenda = new CAMADAS.BLL.Venda();
            CAMADAS.MODEL.Venda venda = new CAMADAS.MODEL.Venda();
            int id = Convert.ToInt32(txtCodVenda.Text);

            string msg = "Confirma a seleção de Cliente?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Selecionar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resp == DialogResult.Yes)
            {
                venda.idVenda = id;
                venda.dataVenda = dtpVenda.Value;
                venda.idCli = Convert.ToInt32(txtCodCli.Text);
                venda.total = 0;
                if (id == -1)
                {
                    bllVenda.Insert(venda);
                }
                else
                {
                    MessageBox.Show("ERRO AO DAR INSERT", "ERRO", MessageBoxButtons.OK);
                }               
            }
            dgvCli.DataSource = "";
            dgvCli.DataSource = bllVenda.Select();
            Limpar();
            Habilitar(false);
            
        }
    }
}
