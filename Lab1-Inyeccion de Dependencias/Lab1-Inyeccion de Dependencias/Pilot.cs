namespace Lab1_Inyeccion_de_Dependencias
{
    public class Pilot : Integrante
    {
        public int PuntosSuperLicencia { get; set; }
        public int Licencia { get; set; }
        public int CampeonatosGanados { get; set; }
        public int CarrerasGanadas { get; set; }
        public int PuntosTemporada { get; set; }
        public Pilot()
        {
            Name = getName();
            Age = new Random().Next(35);
            Licencia = new Random().Next(220000);
            PuntosSuperLicencia = new Random().Next(100);
            CampeonatosGanados = new Random().Next(10);
            CarrerasGanadas = new Random().Next(24);
            PuntosTemporada = new Random().Next(500);
        }

        private string getName()
        {
            var rdm = new Random().Next(7);
            switch (rdm)
            {
                case 0: return ("Max Verstpen");
                case 1: return ("Lewis Hamilton");
                case 2: return ("George Russell");
                case 3: return ("Lando Norris");
                case 4: return ("Sergio Pérez");
                case 5: return ("Fernando Alonso");
                case 6: return ("Charles Leclerc");
                case 7: return ("Carlos Sainz Jr.");
                default: return ("Valtteri Bottas");
            }
        }
    }
}
