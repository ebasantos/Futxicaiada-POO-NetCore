using Jaulas;
using System;

namespace MiniCursoAspNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var leao = new Leao("caramelo", "mufasa");
            var informacoesEntrada = new CoordenaçãoZoo.ServicosZoo().ContabiliarEntradaLeao(leao);
            Console.WriteLine(informacoesEntrada);
            Console.ReadLine();
        }
    }
}
