int tvalor;
int treservacion;

Console.WriteLine("diga su nombre");
string nombre = Console.ReadLine();
do
{
Console.WriteLine("Que  tipo de reservacion desea?");
Console.WriteLine("1.por Hora");
Console.WriteLine("2.por Dia");
Console.WriteLine("3.por Mes");
Console.WriteLine("4.Salir");

 treservacion = ConvertToInt(Console.ReadLine);
switch (treservacion)
    {
    case 1: Console.WriteLine("El valor por Hora es 30000"); 
            Console.WriteLine("cuantas Horas desea reservar?");
            int CHora=ConvertToInt(Console.ReadLine());
            tvalor = 30000*CHora;
            break;

    case 2: Console.WriteLine("El valor por dia es 720000"); 
            Console.WriteLine("cuantos dias desea reservar?");
            int Cdia=ConvertToInt(Console.ReadLine());
            tvalor = 720000*Cdia;
            break;

    case 3: Console.WriteLine("El valor por mes 8000000"); 
            Console.WriteLine("cuantos meses desea reservar?");
            int Cmes=ConvertToInt(Console.ReadLine());
            tvalor = 8000000*Cmes;
            break;
    case 4: Console.WriteLine ("Usted esta saliendo");
            break;
    }
}while (treservacion!= 4);

