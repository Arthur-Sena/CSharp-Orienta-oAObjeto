using EscolaDeRock_Tarde.Interfaces;

namespace EscolaDeRock_Tarde.Models
{
    public class Contrabaixo : InstrumentoMusical, IPercussao, IHarmonia
    {

        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo como um(a) {0}", this.GetType().Name);
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes como um(a) {0}", this.GetType().Name);
            return true;
        }
    }
    
}