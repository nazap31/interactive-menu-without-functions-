Console.WriteLine("\n\nMenu interactivo!");
int firstNumber;
int secondNumber;
Console.WriteLine("\nBienvenido al programa de operaciones matematicas de dos numeros!");
Console.WriteLine("\n Ingrese los numeros con los cuales va a trabajar...");
Console.WriteLine("\n Ingrese el primer numero: ");
firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("\n Ingrese el segundo numero : ");
secondNumber = int.Parse(Console.ReadLine());


Console.WriteLine("\nElija cual operacion matematica desea hacer");



Console.Write("(1) Suma de dos numeros");
Console.Write(" (2) Resta de dos numeros");
Console.Write("  (3) Multiplicacion de dos numeros");
Console.Write("   (4) Division de dos numeros");
Console.Write("\n\n(5) Salir");



Console.WriteLine("\n\nPorfavor escriba el numero de la opcion que desea:");

int opcion;
opcion = int.Parse(Console.ReadLine());
if (opcion == 1)
{
    Console.WriteLine("Ha elegido la suma...");
    Console.WriteLine("La suma de los  numeros ingresados es :  ");
    Console.Write(firstNumber + secondNumber);

} 

if (opcion == 2)
{
    Console.WriteLine("Ha elegido la resta...");
    Console.WriteLine("La resta de los  numeros ingresados es :  ");
    Console.Write(firstNumber - secondNumber);

} 
if (opcion == 3)
{
    Console.WriteLine("Ha elegido la multiplicacion...");
    Console.WriteLine("La multiplicacion de los numeros ingresados es :  ");
    Console.Write(firstNumber * secondNumber);

} 
if (opcion == 4)
{
    Console.WriteLine("Ha elegido la division...");
    Console.WriteLine("La division de los numeros ingresados es :  ");
    Console.Write(firstNumber / secondNumber);

} 
if (opcion == 5)
{
    Console.WriteLine("\nHa elegido salir del programa...");

} 

if (opcion > 5)
{
    Console.WriteLine("Porfavor ingrese una opcion valida");
}

//menu interactivo sin funciones


















