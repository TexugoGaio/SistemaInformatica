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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void Habilitar(bool status)
        {
            txtDescricao.Enabled = status;
            txtMarca.Enabled = status;
            txtValor.Enabled = status;
            txtEstoque.Enabled = status;
            dgvProdutos.Enabled = !status;

            //botoes
            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dgvProdutos.SelectedRows.Count > 0)
            {
                txtID.Text = dgvProdutos.SelectedRows[0].Cells["idProd"].Value.ToString();
                txtDescricao.Text = dgvProdutos.SelectedRows[0].Cells["descricao"].Value.ToString();
                txtMarca.Text = dgvProdutos.SelectedRows[0].Cells["marca"].Value.ToString();
                txtValor.Text = dgvProdutos.SelectedRows[0].Cells["valor"].Value.ToString();
                txtEstoque.Text = dgvProdutos.SelectedRows[0].Cells["estoque"].Value.ToString();
            }
        }

        private void LimparCampos()
        {
            txtID.Text = "";
            txtDescricao.Text = "";
            txtMarca.Text = "";
            txtValor.Text = "";
            txtEstoque.Text = "";
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto();
            dgvProdutos.DataSource = bllProd.Select();
            Habilitar(false);           
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtID.Text = "-1";
            Habilitar(true);
            txtDescricao.Focus();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string msg;
            if(txtID.Text != string.Empty)
            {
                msg = "Confirma a remoção do produto " + txtDescricao.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if(resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtID.Text);
                    CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto();
                    CAMADAS.MODEL.Produto produto = new CAMADAS.MODEL.Produto();
                    produto.idProd = id;
                    bllProd.Delete(produto);
                    dgvProdutos.DataSource = "";
                    dgvProdutos.DataSource = bllProd.Select();
                }
            }
            else
            {
                msg = "Não há registro para remoção.";
                MessageBox.Show(msg, "Remover", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(txtID.Text != string.Empty)
            {
                Habilitar(true);
                txtDescricao.Focus();
            }
            else
            {
                string msg = "Não há registro para edição.";
                MessageBox.Show(msg, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto();
            CAMADAS.MODEL.Produto produto = new CAMADAS.MODEL.Produto();
            int id = Convert.ToInt32(txtID.Text);

            string msg = "";
            if (id == -1)
                msg = "Confirma a Inclusão de dados?";
            else msg = "Confirma a Atualização de dados?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(resp == DialogResult.Yes)
            {
                produto.idProd = id;
                produto.descricao = txtDescricao.Text;
                produto.valor = Convert.ToSingle(txtValor.Text);
                produto.marca = txtMarca.Text;
                produto.estoque = Convert.ToInt32(txtEstoque.Text);

                if (id == -1)
                    bllProd.Insert(produto);
                else bllProd.Update(produto);

                dgvProdutos.DataSource = "";
                dgvProdutos.DataSource = bllProd.Select();
            }
            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = bllProd.Select();
            LimparCampos();
            Habilitar(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Habilitar(false);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Habilitar(false);
        }
    }
}
