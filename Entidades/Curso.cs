namespace FundamentosNetCorePlatzi.Entidades
{
    public class Curso
    {
        public string nombre { get; set; }
        public string uniqueId { get; private set; }
        public TiposJornada Jornada { get; set; }

        // public Curso()
        // {
        //     uniqueId = Guid.NewGuid().ToString();
        // }

        public Curso() => uniqueId = Guid.NewGuid().ToString();

    }
}