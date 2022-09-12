//elágazások
//if
/*
 * if (feltétel)
 * {
 *  valami kód, ha a feltétel igaz
 * }
 */

using System.Globalization;

Console.WriteLine("Szeretsz programozni?");
string valasz = Console.ReadLine();

if (valasz == "igen")
    Console.WriteLine("Az jó, mert amúgy azért jöttél ide,hogy azt tanuld!");
else if (valasz == "nem")
    Console.WriteLine("hát az para lesz akkor...");
else
    Console.WriteLine("nem tudom értelmezi a válaszod :(");

//---------------------------

Console.Write("írd be az osztályzatot: ");
string osztalyzat = Console.ReadLine();
switch (osztalyzat)
{
    case "elégtelen":
        Console.WriteLine("sajnos meg kell ismételned");
        break;
    case "elégséges":
        Console.WriteLine("majd legközelebb jobban fog menni");
        break;
    case "közepes":
        Console.WriteLine("azért még kell majd gyakorolnod");
        break;
    case "jó":
        Console.WriteLine("gratulálok, szép munka!");
        break;
    case "jeles":
        Console.WriteLine("jár a buksisimi");
        break;
    default:
        Console.WriteLine("ilyen nincs is!");
        break;
}

Console.WriteLine("\n\nez a sor pedig a switch után fut le\n\n");

//---------------------------

//                    0         1         2        3        4
int[] szamok =   {    6,        7,       14,      11,      24   };
string[] nevek = { "Eszter", "Szofi", "Botond", "Zoli", "Laczkó"};

Console.WriteLine($"a szamok nevű tömb hossza: {szamok.Length}");

for (int i =  0; i < szamok.Length; i++)
{
    Console.WriteLine($"{nevek[i]} kedvenc száma {szamok[i]}!");
}

Console.WriteLine("ide");