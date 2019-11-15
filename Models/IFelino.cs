namespace Jaulas
{
    public interface IFelino
    {
        string Pelagem { get; set; }
        int TempoVida();
        string TipoAlimentacao();
        string Comunicacao();
        bool Violento();
    }
}
