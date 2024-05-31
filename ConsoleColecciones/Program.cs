// See https://aka.ms/new-console-template for more information

using ConsoleColecciones;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

int[] arrayInts = [5, 5, 6, 7, 2, 19, 100];

var consulta = //Aqui NO se ejecuta la "consulta"
    from entero in arrayInts.Distinct()  //para cada elemento llamado entero en arrayInts que sea par sme lo ordenas y selecionas el numero
    where (entero % 2 == 0 && entero > 4)
    orderby entero descending
    select entero;

arrayInts.Append(8);


foreach (var item in consulta) //Aqui es cuando se ejecuta la "consulta"
{
    Console.WriteLine(item);
}
List<Tablon> Balsa =
[
    new Tablon() { dureza = 8, madera = "pino" },
    new Tablon() { dureza = 7, madera = "caoba" },
    new Tablon() { dureza = 23, madera = "caoba" },
    new Tablon() { dureza = 37, madera = "caoba" },
];

//GROUPBY EN LINQ

var agrupado=from p in Balsa 
    group p by p.madera
    into g
    select g;
// Aqui nos recorremos los 2 elementos de la agrupacion
foreach (var item in agrupado)
{
    Console.WriteLine(item.Key.ToString()); //Así accedemos a la clave
    foreach (var item2 in item) //Aqui recorremos los elementos dentro de la agrupacion
    {
        Console.Write(item2.dureza+ " : ");
        Console.WriteLine(item2.madera);
    }
}

//Esta es la forma que mas le gusta a Jacinto
var consulta2 =
        from item in Balsa
        where item.dureza > 2
        orderby item.madera
        select (item.madera,item.dureza);

IEnumerable<string> consulta3;
    Balsa.
    Where(x => x.dureza > 2). //where(x=>x.locojo().
    OrderBy(x => x.madera).
    Select(x => x.madera);

    var valor=Balsa.Where(x => x.dureza > 2).Sum(x => x.dureza);
    var coleccion2 = Balsa.OrderBy(x => x.madera);
    var durezaMaxima = Balsa.Max(x => x.dureza);

foreach (var item in consulta2)
{
    Console.WriteLine(item.dureza);
    Console.WriteLine(item.madera);
}