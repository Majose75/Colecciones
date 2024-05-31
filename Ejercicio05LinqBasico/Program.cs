// See https://aka.ms/new-console-template for more information
// PARTE UNO

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.JavaScript;
using Ejercicio05LinqBasico;

int[] arrayDeEnteros = [1, 4, 5, 6, 1, 2, 6, 7];

// 1. Mostrar aquellos que son mayores que 2

IEnumerable<int> consulta1;
consulta1 = from numero in arrayDeEnteros
    where (numero > 2)
    select numero;

Console.WriteLine("\nNúmeros mayores de 2: ");

foreach (var item in consulta1)
{
    Console.WriteLine(item);
}

// 2. Mostrar aquellos que son menores que 5

IEnumerable<int> consulta2;
consulta2 = from numero in arrayDeEnteros
    where (numero < 5)
    select numero;

Console.WriteLine("\nNúmeros menores de 5: ");

foreach (var item in consulta2)
{
    Console.WriteLine(item);
}

// 3. Mostrar aquellos que son mayores que 2 pero ordenados de mayor a menor.

IEnumerable<int> consulta3;
consulta3 = from numero in arrayDeEnteros
    where (numero > 2)
    orderby numero
    select numero;

Console.WriteLine("\nNúmeros mayores de 2 ordenados de menor a mayor: ");

foreach (var item in consulta3)
{
    Console.WriteLine(item);
}

// 4. Mostrar aquellos números que son únicos.

IEnumerable<int> consulta4;
consulta4 = from numero in arrayDeEnteros.Distinct()
    select numero;

Console.WriteLine("\nNúmeros únicos: ");


foreach (var item in consulta4)
{
    Console.WriteLine(item);
}

// 5. Mostrar los números pares.

IEnumerable<int> consulta5;
consulta5 = from numero in arrayDeEnteros
    where (numero % 2 == 0)
    select numero;

Console.WriteLine("\nNúmeros pares: ");

foreach (var item in consulta5)
{
    Console.WriteLine(item);
}

// 6. Mostrar los números pares mayores de 4 ordenados de menor a mayor

IEnumerable<int> consulta6;
consulta6 = from numero in arrayDeEnteros
    where (numero % 2 == 0) && numero > 4
    orderby numero descending
    select numero;

Console.WriteLine("\nNúmeros pares mayores de 4 ordenados de menor a mayor: ");

foreach (var item in consulta6)
{
    Console.WriteLine(item);
}

// PARTE DOS

string[] arrayDeCadenas = ["Alberto", "Jacinto", "Adrian", "Merche", "Eva", "Maria"];

// 1. Ordenar la lista alfabeticamente.

var ConsultaCadena1 =
    from cadena in arrayDeCadenas
    orderby cadena ascending 
    select cadena;

Console.WriteLine("\nLista ordenada alfabéticamente: ");

foreach (var item in ConsultaCadena1)
{
    Console.WriteLine(item);
}

// 2. Ordenar la lista alfabeticamente al reves.

var ConsultaCadena2 =
    from cadena in arrayDeCadenas
    orderby cadena descending
    select cadena;

Console.WriteLine("\nLista ordenada alfabéticamente al revés: ");

foreach (var item in ConsultaCadena2)
{
    Console.WriteLine(item);
}

// 3. Ordenar la lista por el número de caracteres de cada palabra

var ConsultaCadena3=
    from cadena in arrayDeCadenas
    orderby cadena.Length
    select cadena;

Console.WriteLine("\nLista ordenada por número de caracteres de cada palabra: ");

foreach (var item in ConsultaCadena3)
{
    Console.WriteLine(item);
}

// 4. Seleccionar aquellas cadenas que comiencen por 'a' y terminen por 'o' u 'n'.

var consultaCadena4 =
    from cadena in arrayDeCadenas
    where cadena.StartsWith("a",StringComparison.OrdinalIgnoreCase) && cadena.EndsWith("o") || cadena.EndsWith("n")
    select cadena;

Console.WriteLine("\nCadenas que comiencen por 'a' y terminen por 'o' u 'n': ");

foreach (var item in consultaCadena4)
{
    Console.WriteLine(item);
}

// 5. Seleccionar aquellas cadenas cuya longitud sea mas de 4 caracteres.

var consultaCadena5 =
    from cadena in arrayDeCadenas
    where cadena.Length > 4 
    select cadena;

Console.WriteLine("\nCadenas cuya longitud sea mas de 4 caracteres: ");

foreach (var item in consultaCadena5)
{
    Console.WriteLine(item);
}

// PARTE TRES

List<Persona> Sujeto =
[
    new Persona() { nombre = "Manolo", fechaNacimiento = new DateTime(1978,06,26),sueldo = 2400 },
    new Persona() { nombre = "Ana", fechaNacimiento = new DateTime(1982,07,27),sueldo=3200 },
    new Persona() { nombre = "Felipe", fechaNacimiento = new DateTime(1995,06,29),sueldo=2100},
    new Persona() { nombre = "Ambrosio", fechaNacimiento = new DateTime(1994,06,28),sueldo = 2000 },
    new Persona() { nombre = "Raquel", fechaNacimiento = new DateTime(2000,05,25),sueldo=1500 },
    new Persona() { nombre = "Luisa", fechaNacimiento = new DateTime(2002,02,20),sueldo=1600 },
    new Persona() { nombre = "Ernesto", fechaNacimiento = new DateTime(2010,01,10),sueldo=600}
];

// 1. Ordenar la colección por sueldo de menos a más.

var consultaPersona1=
    from item in Sujeto
    orderby (item.sueldo)
    select item;

Console.WriteLine("\nLista ordenada por sueldo: ");

foreach (var item in consultaPersona1)
{
    Console.WriteLine(item.sueldo);
}

// 2. Seleccionar aquellos que sean mayores de edad.

DateTime fechaActual=DateTime.Today;

var consultaPersona2 =
    from item in Sujeto
    where (fechaActual.Year - (item.fechaNacimiento).Year) >= 18
    select item;

Console.WriteLine("\nLos de mayor de edad son: ");

foreach (var item in consultaPersona2)
{
    Console.WriteLine(item.nombre + " nació el año: " + (item.fechaNacimiento).Year);
}

// 3. Ordenar por edad de más joven a menos joven.

var consultaPersona3 =
    from item in Sujeto
    orderby (item.fechaNacimiento).Year descending 
    select item;

Console.WriteLine("\nOrdenados de menor a mayor edad: ");

foreach (var item in consultaPersona3)
{
    Console.WriteLine(item.nombre + " nació el año: " + (item.fechaNacimiento).Year);
}

// 4. Seleccionar aquellos cuyo nombre comienza por A o por E

var consultaPersona4 =
    from item in Sujeto
    where item.nombre.StartsWith("a", StringComparison.OrdinalIgnoreCase) || item.nombre.StartsWith("e", StringComparison.OrdinalIgnoreCase)
    select item;

Console.WriteLine("\nNombres que comienzan por A o E: ");

foreach (var item in consultaPersona4)
{
    Console.WriteLine(item.nombre);
}

// 5. Saber cual es el sueldo total.

var consultaPersona5 = Sujeto.Sum(x=>x.sueldo);

Console.WriteLine("\nEl Sueldo total es de : " + consultaPersona5.ToString());

// 6. Saber cual es el sueldo medio.

var consultaPersona6 = Sujeto.Average(x => x.sueldo);

Console.WriteLine("\nEl Sueldo Medio es de : " + consultaPersona6.ToString());

// 7. Ordenar por sueldo, para aquellos mayores de edad que tienen un sueldo par.

var consultaPersona7 =
    Sujeto.Where(item => (item.sueldo % 2 == 0) && ((fechaActual.Year - (item.fechaNacimiento).Year) >= 18))
        .OrderBy(item => item.sueldo);

Console.WriteLine("\nOrdenar por sueldo, para aquellos mayores de edad que tienen un sueldo par: ");

foreach (var item in consultaPersona7)
{
    Console.WriteLine(item.nombre + " " + item.fechaNacimiento + " " + item.sueldo);
}