using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3A1JOAO47
{
    public partial class Frm_categoria : Form
    {
        public Frm_categoria()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Categoria obj = new Categoria();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.descricao = txtDescricao.Text;
            obj.tipo = txtTipo.Text;
            obj.Cadastrar();
            MessageBox.Show("Cadastro Efetuado!");
            txtId.Clear();
            txtDescricao.Clear();
            txtTipo.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Categoria obj = new Categoria();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.descricao = txtDescricao.Text;
            obj.tipo = txtTipo.Text;
            obj.Alterar();
            MessageBox.Show("Alteração Efetuada!");
            txtId.Clear();
            txtDescricao.Clear();
            txtTipo.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Categoria obj = new Categoria();
            obj.id = int.Parse(txtId.Text);
            obj.Excluir();
            MessageBox.Show("Excluído com Sucesso!");
            txtId.Clear();
            txtDescricao.Clear();
            txtTipo.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Categoria obj = new Categoria();
            dataGridView1.DataSource = obj.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_brinquedos Frm_brinquedos = new Frm_brinquedos();
            Frm_brinquedos.ShowDialog();
        }
    }
}
