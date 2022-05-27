// See https://aka.ms/new-console-template for more information
using FundamentosNetCorePlatzi.Entidades;

var escuela = new Escuela("San Marcos", 2010,TiposDeEscuela.Primaria,
                            pais: "Perú", ciudad: "Lima1"
);


escuela.Cursos = new List<Curso>(){
                    new Curso(){ nombre ="101", Jornada = TiposJornada.Mañana},
                    new Curso(){ nombre ="201", Jornada = TiposJornada.Mañana},
                    new Curso(){ nombre ="301", Jornada = TiposJornada.Tarde}
};

escuela.Cursos.Add(new Curso(){nombre = "102", Jornada = TiposJornada.Tarde});
escuela.Cursos.Add(new Curso(){nombre = "202", Jornada = TiposJornada.Tarde});

var otrCollection = new List<Curso>(){
                    new Curso(){ nombre ="401", Jornada = TiposJornada.Mañana},
                    new Curso(){ nombre ="501", Jornada = TiposJornada.Mañana},
                    new Curso(){ nombre ="502", Jornada = TiposJornada.Tarde}
};

escuela.Cursos.AddRange(otrCollection);


Console.WriteLine(escuela);
Console.WriteLine("================");

for (int i = 0; i < escuela.Cursos.Count(); i++)
{
    Console.WriteLine("Curso " + i + " | Nombre : " + escuela.Cursos[i].nombre + 
    " | UniqueId : " + escuela.Cursos[i].uniqueId);
}

escuela.Cursos.RemoveAll(delegate (Curso cur){
    return cur.nombre == "401";
});

escuela.Cursos.RemoveAll((cur1) => cur1.nombre == "501");

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
        } while (contador < arregloCursos.Count());
    }


}
