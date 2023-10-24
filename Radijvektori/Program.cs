using Radijvektori;

Radijvektor a; // = new Radijvektor();
a.X = 5; a.Y = 6; a.Z = -1; 
Console.WriteLine(a.ToString());
Radijvektor b = new Radijvektor();
Console.WriteLine(b.ToString());
Radijvektor c = default;
Console.WriteLine(c.ToString());

Radijvektor d;
Unos(out d);
Console.WriteLine(d.ToString());

INorma e = d;
d.Normiraj();
Console.WriteLine(e.ToString());
Console.WriteLine(d);

/* Radijvektor[] radijvektori = new Radijvektor[10];
foreach(Radijvektor v in radijvektori)
{
    Console.WriteLine(v);
} */

/* Temp d = new Temp();
Console.WriteLine(d.R);
internal class Temp
{
    public Radijvektor R;
} */

static void Unos(out Radijvektor a)
{ 
    while (true)
    {
        Console.Write("Unesite koordinate odvojene razmakom: ");
        var ulaz = Console.ReadLine();
        if (ulaz == null)
            continue;
        var koordinate = ulaz.Split(' ');
        if (koordinate.Length != 3)
            continue;
        if (!double.TryParse(koordinate[0], out a.X)
            || !double.TryParse(koordinate[1], out a.Y)
            || !double.TryParse(koordinate[2], out a.Z))
            continue;
        break;
    }
}