using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace _3A1JOAO47
{
    class Brinquedos
    {
        public int id;
        public string nome;
        public double preco;

        Conexao obj = new Conexao();

        public void Cadastrar()
        {

            string inserir = $@"insert into brinquedos values ('{id}', '{nome}', '{preco}');";
            obj.ExecutarComando(inserir);

        }

        public DataTable Listar()     //Requer: using System.Data;
        {
            string listar = $"SELECT * FROM brinquedos; ";
            return obj.ExecutarConsulta(listar);
        }
        public void Excluir()
        {
            string deletar = $"DELETE FROM brinquedos WHERE id = '{id}'; ";
            obj.ExecutarComando(deletar);
        }

        public void Alterar()
        {
            string alterar = $"UPDATE brinquedos SET nome = '{nome}', preco = '{preco}' WHERE id = '{id}'";
            obj.ExecutarComando(alterar);
        }
    }
}
