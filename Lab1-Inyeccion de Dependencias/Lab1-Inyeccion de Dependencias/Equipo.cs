using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace Lab1_Inyeccion_de_Dependencias
{

    public interface ITransientE
    {

    }
    public interface IScopedE
    {

    }
    public interface ISingeltonE
    {

    }
    public class Equipo : ITransientE, ISingeltonE, IScopedE
    {
        public readonly String Escuderia;
        public ISingelton Piloto1;
        public ITransient Piloto2;
        

        public Equipo(ISingelton _piloto1, ITransient _piloto2)
        {
            Escuderia = getName();
            Piloto1 = _piloto1;
            Piloto2 = _piloto2;

        }

        private string getName()
        {
            var rdm = new Random().Next(7);
            switch (rdm)
            {
                case 0: return ("Red Bull Racing");
                case 1: return ("Williams");
                case 2: return ("Alpine");
                case 3: return ("Ferrari");
                case 4: return ("Mercedes");
                case 5: return ("McLaren F1");
                case 6: return ("Alfa Romeo");
                case 7: return ("Haas F1 Team");
                default: return ("AlphaTauri");
            }
        }
    }
}
