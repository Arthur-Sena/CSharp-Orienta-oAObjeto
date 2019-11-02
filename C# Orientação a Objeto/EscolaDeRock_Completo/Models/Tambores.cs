using EscolaDeRock_Tarde.Interfaces;

namespace EscolaDeRock_Tarde.Models
{
    public class Tambores : InstrumentoMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo como um(a) {0}", this.GetType().Name);
            return true;
        }
    }
}