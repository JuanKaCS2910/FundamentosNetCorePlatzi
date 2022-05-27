namespace FundamentosNetCorePlatzi.Entidades
{
    public enum TiposDeEscuela
    {
        Primaria,
        Secundaria, 
        PreEscolar
    }

    
    public class Escuela 
    {
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value.ToUpper(); }
        }

        public int AñoDeCreacion { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TiposDeEscuela tipoEscuela { get; set; }
        public List<Curso> Cursos { get; set; }

        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);

        //Constructor con parámetros opcionales
        public Escuela(string nombre, int año, 
                       TiposDeEscuela tipo, 
                       string pais = "", string ciudad = "")
        {
            
            (Nombre, AñoDeCreacion) = (nombre, año);//Asignación de tuplas.
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            //return $"Nombre : \"{Nombre}\", Tipo : {tipoEscuela} \n Pais : {Pais}, Ciudad :{Ciudad}";
            return $"Nombre : \"{Nombre}\", Tipo : {tipoEscuela} {System.Environment.NewLine} Pais : {Pais}, Ciudad :{Ciudad}";
        }

    }
}