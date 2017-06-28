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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void Habilitar(bool status)
        {
            txtNome.Enabled = status;
            txtEndereco.Enabled = status;
            txtEstado.Enabled = status;
            txtCidade.Enabled = status;
            txtCelular.Enabled = status;
            txtEmail.Enabled = status;
            dgvCliente.Enabled = !status;

            //botoes
            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;


        }

        private void LimparCampos()
        {
            txtiD.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtEstado.Text = "";
            txtCidade.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.Cliente bllCliente = new CAMADAS.BLL.Cliente();
            dgvCliente.DataSource = bllCliente.Select();
            Habilitar(false);
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            if(dgvCliente.SelectedRows.Count > 0)
            {
                txtiD.Text = dgvCliente.SelectedRows[0].Cells["idCli"].Value.ToString();
                txtNome.Text = dgvCliente.SelectedRows[0].Cells["nome"].Value.ToString();
                txtEndereco.Text = dgvCliente.SelectedRows[0].Cells["endereco"].Value.ToString();
                txtCidade.Text = dgvCliente.SelectedRows[0].Cells["cidade"].Value.ToString();
                txtEstado.Text = dgvCliente.SelectedRows[0].Cells["estado"].Value.ToString();
                txtCelular.Text = dgvCliente.SelectedRows[0].Cells["celular"].Value.ToString();
                txtEmail.Text = dgvCliente.SelectedRows[0].Cells["email"].Value.ToString();
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtiD.Text = "-1";
            Habilitar(true);
            txtNome.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(lbliD.Text != string.Empty)
            {
                Habilitar(true);
                txtNome.Focus();
            }
            else
            {
                string msg = "NÃO HÁ REGISTRO PARA EDIÇÃO";
                MessageBox.Show(msg, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Cliente bllCliente = new CAMADAS.BLL.Cliente();
            CAMADAS.MODEL.Cliente cliente = new CAMADAS.MODEL.Cliente();
            int id = Convert.ToInt32(txtiD.Text);

            string msg = "";
            if (id == -1) // id = -1 (INCLUSÃO)   E   id != -1 (ATUALIZAÇÃO)
            {
                msg = "confirma inclusão de dados?";
            }
            else
            {
                msg = "confirma atualização de dados?";
            }

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(resp == DialogResult.Yes)
            {
                cliente.idCli = id;
                cliente.nome = txtNome.Text;
                cliente.endereco = txtEndereco.Text;
                cliente.cidade = txtCidade.Text;
                cliente.estado = txtEstado.Text;
                cliente.celular = txtCelular.Text;
                cliente.email = txtEmail.Text;

                if(id == -1) // -1 indica inserir
                {
                    bllCliente.Insert(cliente);
                }
                else
                {
                    bllCliente.Update(cliente);
                }  
            }
            dgvCliente.DataSource = "";
            dgvCliente.DataSource = bllCliente.Select(); // atualiza a grid
            LimparCampos();
            Habilitar(false);

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string msg;
            if(txtiD.Text != string.Empty)
            {
                msg = "Confirma a exclusão do Cliente " + txtNome.Text + " ?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                if(resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtiD.Text);
                    CAMADAS.BLL.Cliente bllCliente = new CAMADAS.BLL.Cliente();
                    CAMADAS.MODEL.Cliente cliente = new CAMADAS.MODEL.Cliente();
                    cliente.idCli = id;
                    //informar outros campos caso necessite no bll
                    bllCliente.Delete(cliente);
                    dgvCliente.DataSource = "";
                    dgvCliente.DataSource = bllCliente.Select();
                }
            }
            else
            {
                msg = "Não há registro para remoção.";
                MessageBox.Show(msg, "Remover", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            LimparCampos();
            Habilitar(false);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Habilitar(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Habilitar(false);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
