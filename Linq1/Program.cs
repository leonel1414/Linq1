//¿Qué es LINQ?
//Language Integrated Query

// 1. Nuesto origen de datos
int[] numbers = new int[10] { 1,2,3,4,5,6,7,8,9,10};

// 2. Obtener datos con una consulta

/// Ejemplo: seleccionar los numero pares

 var impares =  
    from numero in numbers
    where ( numero % 2 ) != 0
    select numero;

 var consulta =
    from numero in numbers
    where (numero % 2) == 0
    select numero;

// 3. Ejecutar la consulta
foreach (var num in consulta) {
    Console.Write(num + " ");
}

Console.WriteLine("\n Numeros impares:");
foreach (var num in impares)
{
    Console.Write(num + " ");
}

//Utilizar en nuestro programa