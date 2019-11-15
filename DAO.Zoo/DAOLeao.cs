using Jaulas;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO.Zoo
{
    public class DAOLeao : DAO.Zoo.Conexao
    {
        public string CadastrarLeao(Leao leao)
        {
            try
            {
                string sql = $"INSERT INTO Jaula (NumeroJaula, NomeAnimal, TipoAnimal) values ({leao.NumeroJaula}, '{leao.Nome}', '{leao.GetType().Name}')";
                ExecutorSql.CommandText = sql;
                ExecutorSql.ExecuteNonQuery();
                return "Leao cadastrado com sucesso";
            }
            catch (Exception ex)
            {
                return $"Ocorreu o seguinte erro ao cadastrar o animal : {ex.Message}";
            }
        }
    }
}
