using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3A1JOAO47
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.nome = txtNome.Text;
            obj.senha = txtSenha.Text;

            if (obj.Logar() == true)
            {
                Frm_brinquedos Frm_brinquedos = new Frm_brinquedos();
                Frm_brinquedos.ShowDialog();
            }
            else { MessageBox.Show("Usuario ou Senha incorretos!", "Erro", MessageBoxButtons.OK); }
        }
    }
}
