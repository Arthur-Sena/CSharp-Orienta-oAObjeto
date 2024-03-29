using EscolaDeRock_Tarde.Interfaces;

namespace EscolaDeRock_Tarde.Models
{
    public class Piano : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes como um(a) {0}", this.GetType().Name);
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo como um(a) {0}", this.GetType().Name);
            return true;
        }
    }
}