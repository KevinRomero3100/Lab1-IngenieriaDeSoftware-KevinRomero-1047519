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

    public class Integrante: ITransient, IScoped, ISingelton
    {
        public  int Age;
        public string Name;
    }
}
