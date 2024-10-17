//============ 1.Palindrome Tekshiruvi ============//

Console.Write("Satrni kiriting: ");
string matn = Console.ReadLine();

bool isPalindrome = true;

for (int i = 0; i < matn.Length / 2; i++)
{
    for (int j = matn.Length-1-i; j >= matn.Length / 2; j--)
    {
        if (matn[i] != matn[j])
        {
            isPalindrome = false;
            break;
        }
    break;
    }
    if (!isPalindrome)
    {
        break;  
    }
}

if (isPalindrome)
{
    Console.WriteLine("Palindrome");
}
else
{
    Console.WriteLine("Palindrome emas");
}


//============ 2.Temperatura o'girish ============//

Console.Write("Temperaturani kiriting(°C): ");
double selsiy = double.Parse(Console.ReadLine());




switch (selsiy)
{
    default:
        double farangit = (9.0 /5.0) * selsiy + 32;
        
        double kelvin = selsiy + 273.15;

        Console.WriteLine($"Selsiyus: {selsiy}, Fahrenheit: {farangit}, Kelvin: {kelvin}");
    break;
}

//============ 3.Sonlarni tartiblash ============//

Console.Write("Iltimos sonlarni vergul bilan ajratib kiriting: ");
string input = Console.ReadLine();

int[] sonlar = input.Split(',').Select(int.Parse).ToArray();

switch (sonlar.Length > 0)
{
    case true:
        Array.Sort(sonlar);
        Console.WriteLine("Tartiblangan qator: " + string.Join(", ", sonlar));

        Array.Reverse(sonlar);
        Console.WriteLine("Teskari tartib: " + string.Join(", ", sonlar));
        break;

    default:
        Console.WriteLine("Siz noto'g'ri ma'lumot kiritdingiz.");
    break;
}

//============ 4.Berilgan matnning simvol sanasini hisoblash ============//

Console.Write("Matn kiriting: ");
string Matn = Console.ReadLine();

Dictionary<char, int> simvollarSoni = new Dictionary<char, int>();

foreach (char simvol in Matn)
{
    if (simvollarSoni.ContainsKey(simvol))
    {
        simvollarSoni[simvol]++;
    }
    else
    {
        simvollarSoni[simvol] = 1;
    }
}

Console.WriteLine("Simvol chastotalari: ");
foreach (var item in simvollarSoni)
{
    Console.WriteLine($"'{item.Key}': {item.Value} martta");
}