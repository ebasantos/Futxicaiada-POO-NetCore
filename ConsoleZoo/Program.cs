using Jaulas;
using System;

namespace MiniCursoAspNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var leao = new Leao("caramelo", "mufasa");

            var resultado = new DAO.Zoo.DAOLeao().CadastrarLeao(leao);
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
