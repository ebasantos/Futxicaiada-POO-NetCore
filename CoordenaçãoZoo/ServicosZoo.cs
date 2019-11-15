using System;

namespace CoordenaçãoZoo
{
    public class ServicosZoo
    {
        public string ContabiliarEntradaLeao(Jaulas.Leao leao)
        {
            if (leao.NumeroJaula < 100000)
            {
                return $"entrada do leao :{leao.Nome}, na jaula: {leao.NumeroJaula}. Alocado na zona A";
            }
            else
            {
                return $"entrada do leao :{leao.Nome}, na jaula: {leao.NumeroJaula}. Alocado na zona B";
            }
        }
    }
}
