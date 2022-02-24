string nomEstudiante="";
float algoritmosNota, mametmaticasNota, espanolNota, promedio;
bool continuar;

do
{
    Console.WriteLine("Digite el nombre del estudiante");
    nomEstudiante = (Console.ReadLine());

    Console.WriteLine("Digite la nota del estudiante en algoritmos");
    algoritmosNota = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite la nota del estudiante en matemáticas");
    mametmaticasNota = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite la nota del estudiante en español");
    espanolNota = float.Parse(Console.ReadLine());

    promedio = (algoritmosNota + mametmaticasNota + espanolNota) / 3;

    Console.WriteLine("Nombre: "  + nomEstudiante  + " Nota de algoritmos:"  +  algoritmosNota + " Nota de matemáticas: "  +  mametmaticasNota + " Nota de espñaol: " + espanolNota);
    Console.WriteLine("El promedio es igual a: " + promedio.ToString("N1"));

    Console.WriteLine("Si desea ingresar otro estudiante digite true, de lo contrario digite false");
    continuar = bool.Parse(Console.ReadLine());
   

} while (continuar);
