// See https://aka.ms/new-console-template for more information
using CoreEscuela.Entidades;
using FundamentosNetCorePlatzi.Entidades;

var escuela = new Escuela("San Marcos", 2010,TiposDeEscuela.Primaria,
                            pais: "Perú", ciudad: "Lima1"
);

var arreglosCursos = new Curso[3];
arreglosCursos[0]= new Curso(){
                        nombre ="101"
                    };
arreglosCursos[1]= new Curso(){
                        nombre ="201"
                    };
arreglosCursos[2]= new Curso(){
                    nombre ="301"
                };
//escuela.tipoEscuela = TiposDeEscuela.Primaria;
//escuela.Ciudad = "Lima";
//escuela.Pais = "Perú";
Console.WriteLine(escuela);
Console.WriteLine("================");
// Console.WriteLine("Curso 1 : " + arreglosCursos[0].nombre + " | " + arreglosCursos[0].uniqueId);
// Console.WriteLine($"Curso 2 : {arreglosCursos[1].nombre} | {arreglosCursos[1].uniqueId}");
// Console.WriteLine(arreglosCursos[2]);

for (int i = 0; i < arreglosCursos.Length; i++)
{
    Console.WriteLine("Curso " + i + " | Nombre : " + arreglosCursos[i].nombre + 
    " | UniqueId : " + arreglosCursos[i].uniqueId);
}
