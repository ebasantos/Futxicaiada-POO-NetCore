using Jaulas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAO.Zoo
{
    public class DAOLeao : DAO.Zoo.Conexao
    {
        public string Cadastrar(Animal animal)
        {
            try
            {
                string sql = $"INSERT INTO Jaula (NumeroJaula, NomeAnimal, TipoAnimal) values ({animal.NumeroJaula}, '{animal.Nome}', '{animal.GetType().Name}')";
                ExecutorSql.CommandText = sql;
                ExecutorSql.ExecuteNonQuery();
                return "Animal cadastrado com sucesso";
            }
            catch (Exception ex)
            {
                return $"Ocorreu o seguinte erro ao cadastrar o animal : {ex.Message}";
            }
        }
        public void Listar()
        {
            string sql = "select * from Jaula";
            ExecutorSql.CommandText = sql;
            var leitor = ExecutorSql.ExecuteReader();

            while (leitor.Read())
            {
                Console.Write($"Espécie: {leitor["TipoAnimal"]}, Nome do animal: {leitor["NomeAnimal"]}, Jaula: {leitor["NumeroJaula"]}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
