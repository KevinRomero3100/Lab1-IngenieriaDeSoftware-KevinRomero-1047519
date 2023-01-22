namespace Lab1_Inyeccion_de_Dependencias
{
    public interface ITransient
    {

    }
    public interface IScoped
    {

    }
    public interface ISingelton
    {

    }

    public class Integrante: ISingelton, ITransient, IScoped
    {
        public  int Age;
        public string Name;
    }
}
