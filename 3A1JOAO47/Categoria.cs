using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace _3A1JOAO47
{
    class Categoria
    {
        public int id;
        public string tipo, descricao;

        Conexao obj = new Conexao();

        public void Cadastrar()
        {

            string inserir = $@"insert into categoria values ('{id}', '{tipo}', '{descricao}');";
            obj.ExecutarComando(inserir);

        }

        public DataTable Listar()     //Requer: using System.Data;
        {
            string listar = $"SELECT * FROM categoria; ";
            return obj.ExecutarConsulta(listar);
        }
        public void Excluir()
        {
            string deletar = $"DELETE FROM categoria WHERE id = '{id}'; ";
            obj.ExecutarComando(deletar);
        }

        public void Alterar()
        {
            string alterar = $"UPDATE categoria SET tipo = '{tipo}', descricao = '{descricao}' WHERE id = '{id}'";
            obj.ExecutarComando(alterar);
        }
    }
}
