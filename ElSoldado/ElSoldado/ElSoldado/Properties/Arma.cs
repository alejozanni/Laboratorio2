namespace ElSoldado.Properties
{
    public abstract class Arma
    {
        protected string _nombre;

        public string GetNombre()
        {
            return _nombre;
        }

        public abstract void Disparar();
    }
}