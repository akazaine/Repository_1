// See https://aka.ms/new-console-template for more information

Console.WriteLine("----==== 1. uzdevums ====----");

Console.WriteLine("Kā tevi sauc?");
string userName = Console.ReadLine();
Console.WriteLine("Sveiks, " + userName  + "!");


Console.WriteLine("----==== 2. uzdevums ====----");

Console.WriteLine("Kāds ir tavs vecums?");
int userAge = int.Parse(Console.ReadLine());
int addNumberToUserAge = userAge + 1;
Console.WriteLine("Nākamgad tev paliks " + addNumberToUserAge + ", Tu esi pilngadīgs!");

Console.WriteLine("----==== 3. uzdevums / 4. udevumus ====----");

Console.WriteLine("Lūdzu ievadiet pirmo skaitli: ");
int firstNr = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu ievadiet otro skaitli: ");
int secondNr = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu ievadiet trešo skaitli: ");
int thirdNr = int.Parse(Console.ReadLine());

int getLarger1 = Math.Max(firstNr, secondNr);
int getLarger2 = Math.Max(getLarger1, thirdNr);
Console.WriteLine("Lielākais ievadītais lietotāja skaitlis: " + getLarger2);


int getSmaller1 = Math.Min(firstNr, secondNr);
int getSmaller2 = Math.Min(getSmaller1, thirdNr);
Console.WriteLine("Mazākais ievadītais lietotāja skaitlis: " + getSmaller2);

Console.WriteLine("----==== 5. uzdevums ====----");

Console.WriteLine("Lūdzu ievadiet pirmo skaitli: ");
int divide1 = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu ievadiet otro skaitli: ");
int divide2 = int.Parse(Console.ReadLine());

Console.WriteLine("Dalījuma atlikums dalot " + divide1 + " ar " + divide2 + " ir: " + divide1 % divide2);

Console.WriteLine("----==== 6. uzdevums ====----");

bool evenNumber = true;
Console.WriteLine("Lūdzu ievadiet skaitli: ");
int userNumber = int.Parse(Console.ReadLine());
evenNumber = userNumber % 2 == 0;
Console.WriteLine("Vai ievadītais skaitlis ir pāra skaitlis:  " + evenNumber);

Console.WriteLine("----==== 7. uzdevums ====----");

Console.WriteLine("Lūdzu ievadiet taisnstūra garākās malas garumu: ");
decimal longSide = decimal.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu ievadiet taisnstūra īsākās malas garumu: ");
decimal smallSide = decimal.Parse(Console.ReadLine());

decimal result = longSide * smallSide;
Console.WriteLine("Taisnstūra laukums ir : " + Math.Round(result, 2));

Console.WriteLine("----==== 8. uzdevums ====----");

Console.WriteLine("Lūdzu ievadiet trijstūra malas garumu: ");
int triangelSide = int.Parse(Console.ReadLine());
//S= (a*b)/2

int result2 = (triangelSide * triangelSide) / 2;
Console.WriteLine("Vienādsānu taisnleņķa trijstūra laukums ir : " + result2);

Console.WriteLine("----==== 9. uzdevums ====----");

Console.WriteLine("Kāds ir Tavs vārds?");
string name = Console.ReadLine();
Console.WriteLine("Kāds ir tavs vecums?");
int age  = int.Parse(Console.ReadLine());

Console.WriteLine($"Sveiks/a, {name}, tavs vecums ir {age}!");