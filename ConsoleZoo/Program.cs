using Jaulas;
using System;

namespace MiniCursoAspNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var leao = new Leao("caramelo", "mufasa");

            //INSERINDO ANIMAL DO BANCO DE DADOS
            var resultado = new DAO.Zoo.DAOLeao().Cadastrar(leao);
            Console.WriteLine(resultado);
            Console.ReadLine();

            //LISTANDO TODOS AS JAULAS 
            new DAO.Zoo.DAOLeao().Listar();
        }
    }
}
