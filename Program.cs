// See https://aka.ms/new-console-template for more information
using FundamentosNetCorePlatzi.Entidades;

var escuela = new Escuela("San Marcos", 2010,TiposDeEscuela.Primaria,
                            pais: "Perú", ciudad: "Lima1"
);


escuela.Cursos = new Curso[]{
                    new Curso(){ nombre ="101"},
                    new Curso(){ nombre ="201"},
                    new Curso(){ nombre ="301"}
};

Console.WriteLine(escuela);
Console.WriteLine("================");

for (int i = 0; i < escuela.Cursos.Length; i++)
{
    Console.WriteLine("Curso " + i + " | Nombre : " + escuela.Cursos[i].nombre + 
    " | UniqueId : " + escuela.Cursos[i].uniqueId);
}
imprimirCursoDoWhile(escuela);

static void imprimirCursoDoWhile(Escuela escuela)
{
    int contador = 0;
    Console.WriteLine("================");
    Console.WriteLine("Do While");

    if (escuela?.Cursos != null) //(escuela!= null && escuela.Cursos != null)
    {
        var arregloCursos = escuela.Cursos;
        do
        {
            Console.WriteLine("Curso " + contador +
             " | Nombre : " + arregloCursos[contador].nombre +
            " | UniqueId : " + arregloCursos[contador].uniqueId);
            contador++;
        } while (contador < arregloCursos.Length);
    }


}
