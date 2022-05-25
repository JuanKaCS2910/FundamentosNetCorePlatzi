// See https://aka.ms/new-console-template for more information
using CoreEscuela.Entidades;
using FundamentosNetCorePlatzi.Entidades;

var escuela = new Escuela("San Marcos", 2010,TiposDeEscuela.Primaria,
                            pais: "Perú", ciudad: "Lima1"
);
var curso1 = new Curso(){
        nombre ="101"
    };
var curso2 = new Curso(){
        nombre ="201"
    };
var curso3 = new Curso(){
        nombre ="301"
    };
//escuela.tipoEscuela = TiposDeEscuela.Primaria;
//escuela.Ciudad = "Lima";
//escuela.Pais = "Perú";
Console.WriteLine(escuela);
Console.WriteLine("================");
Console.WriteLine("Curso 1 : " + curso1.nombre + " | " + curso1.uniqueId);
Console.WriteLine($"Curso 2 : {curso2.nombre} | {curso2.uniqueId}");
Console.WriteLine(curso3);
