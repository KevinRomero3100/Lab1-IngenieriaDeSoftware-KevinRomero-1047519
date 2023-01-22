namespace Lab1_Inyeccion_de_Dependencias
{

    public interface ITransientC
    {

    }
    public interface IScopedC
    {

    }
    public interface ISingeltonC
    {

    }
    public class Carrera : ITransientC, IScopedC, ISingeltonC
    {
        public readonly String Descripcion;
        public IScopedE Equipo1;
        public ITransientE Equipo2;
        public ISingeltonE Equipo3;



        public Carrera(IScopedE _equipo1, ITransientE _equipo2, ISingeltonE _equipo3)
        {
            Descripcion = getName();
            Equipo1 = _equipo1;
            Equipo2 = _equipo2;
            Equipo3 = _equipo3;
        }

        public string getName()
        {
            var rdm = new Random().Next(7);
            switch (rdm)
            {
                case 0: return ("Bahrein – 5 de marzo.");
                case 1: return ("Bakú – 30 de abril.");
                case 2: return ("Monte Carlo – 28 de mayo.");
                case 3: return ("Barcelona – 4 de junio.");
                case 4: return ("Red Bull Ring – 2 de julio.");
                case 5: return ("Imola – 21 de mayo.");
                case 6: return ("Yeda – 19 de marzo.");
                case 7: return ("Haas F1 Team");
                default: return ("Abu Dhabi – 26 de noviembre");
            }
        }
    }
}
