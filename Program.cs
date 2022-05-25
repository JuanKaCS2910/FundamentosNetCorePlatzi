// See https://aka.ms/new-console-template for more information
using CoreEscuela.Entidades;

var escuela = new Escuela("San Marcos", 2010,TiposDeEscuela.Primaria,
                            pais: "Perú", ciudad: "Lima1"
);
//escuela.tipoEscuela = TiposDeEscuela.Primaria;
//escuela.Ciudad = "Lima";
//escuela.Pais = "Perú";
Console.WriteLine(escuela);
