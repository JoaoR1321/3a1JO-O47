using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3A1JOAO47
{
    public partial class Frm_brinquedos : Form
    {
        public Frm_brinquedos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Brinquedos obj = new Brinquedos();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.nome = txtNome.Text;
            obj.preco = Convert.ToDouble(txtPreco.Text);
            obj.Cadastrar();
            MessageBox.Show("Cadastro Efetuado!");
            txtId.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_categoria Frm_categoria = new Frm_categoria();
            Frm_categoria.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Brinquedos obj = new Brinquedos();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.nome = txtNome.Text;
            obj.preco = Convert.ToDouble(txtPreco.Text);
            obj.Alterar();
            MessageBox.Show("Alteração Efetuada!");
            txtId.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Brinquedos obj = new Brinquedos();
            obj.id = int.Parse(txtId.Text);
            obj.Excluir();
            MessageBox.Show("Excluído com Sucesso!");
            txtId.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Brinquedos obj = new Brinquedos();
            dataGridView1.DataSource = obj.Listar();
        }
    }
}
