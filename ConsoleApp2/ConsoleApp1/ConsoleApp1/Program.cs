// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World, it's a nice day!");
//comment
/*
string x = "4";
Console.WriteLine("Hey, izvadi kaut ko lūdzu, piemēram, x= " + x);

int vecums = 55;
double money = 55.22;
Console.WriteLine("My age is not : " + vecums + " weel, not yet :)" + "some money: " + money);

char simbols = 'B';
Console.WriteLine(simbols);

bool iscat = false;

if(true == iscat)
{
    iscat = true;
    Console.WriteLine("iekš ifija: " + iscat);
}
else
{
    iscat = false;
    Console.WriteLine("iekš elses: " + iscat);
}


Console.WriteLine("---===NEW SECTION===---");

int a = 5;
int b = 2;

int sum = a + b;
Console.WriteLine("Summa : " + sum);

int diff = b - a;
Console.WriteLine("Starpība  : " + diff);

int multipl = a * b;
Console.WriteLine("Reizina  : " + multipl);

double divide =(double) a / b; //kastošana
Console.WriteLine("Dala : " + divide); //atgriež tikai veselu skaitli 

int divisionLeft = a % b;
Console.WriteLine("Dalijum atlikums  : " + divisionLeft);

Console.WriteLine("---===NEW SECTION===---");

a++;
b--;

Console.WriteLine(a);
Console.WriteLine(b);

int num1 = 10;
int num2 = 10;

bool isEqual = (num1 == num2);
bool isNotEqual = (num1 != num2);
bool isLarger = (num1 > num2);
bool isSmaller = (num1 < num2);
bool isLargerEqual = (num1 >= num2);
bool isSmallerEqual = (num1 <= num2);

Console.WriteLine(isEqual);
Console.WriteLine(isNotEqual);
Console.WriteLine(isLarger);
Console.WriteLine(isSmaller);
Console.WriteLine(isLargerEqual);
Console.WriteLine(isSmallerEqual);


Console.WriteLine("---===NEW SECTION===---");

int d = 4;

d += 2; // x = x + 2
Console.WriteLine(d);

d -= 3; // x = x - 2
Console.WriteLine(d);


Console.WriteLine("---===NEW SECTION===---");



//1.Prasa ievadīt lietotajvardu 

Console.Write("Ludzu ievadiet savu vārdu: ");

//2. Sagaidam lietotaja vardu

string userName = Console.ReadLine();


//3. Izvadam lietotajvardu

Console.WriteLine("Lietotāja vārds: " + userName);
  

Console.Write("Ludzu ievadiet skaitli: ");
string userNumberStr = Console.ReadLine();
int userNumber = int.Parse(userNumberStr);

int bytenLarger = userNumber + 10;
Console.WriteLine("Lielaks par 10: " + bytenLarger);



int positiveNumber = 15;
int negativeNumber = -15;

int positiveAbs = Math.Abs(positiveNumber);
int negativeAbs = Math.Abs(negativeNumber);

Console.WriteLine("Default negative: " + negativeNumber);
Console.WriteLine(positiveAbs);
Console.WriteLine(negativeAbs);


Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();


int maxNumberHigh = 40;
int maxNumberLow = 29;

int largerNumber = Math.Max(maxNumberHigh, maxNumberLow);

Console.WriteLine("Larger number: " + largerNumber);


Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();


int minNumberHigh = 40;
int minNumberLow = 29;

int smallerNumber = Math.Min(minNumberHigh, minNumberLow);

Console.WriteLine("Smallest number: " + smallerNumber);

Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();

double roundableNumber = 145.58789;
double rounded = Math.Round(roundableNumber, 2);

Console.WriteLine("Number rounded: " + rounded);

*/

Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();

string name = "Artis";
int age2 = 80;

string formattedMessage = $"Hello {name} it is very nice to see you at your age {age2} wich ios very gracefull!";

string formattedMessage2 = "Hello " + name + " it is very nice to see you at your age " + age2 + " wich ios very gracefull!";

Console.WriteLine(formattedMessage);
Console.WriteLine(formattedMessage2);



Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();