using majasDarbs3;

Console.WriteLine("----==== 1. uzdevums ====----");

Telephone telephone = new Telephone();

Console.WriteLine("Lūdzu ievadiet telefona marku: ");
telephone.Brand = Console.ReadLine();
Console.WriteLine("Lūdzu ievadiet telefona modeli: ");
telephone.Model = Console.ReadLine();
Console.WriteLine("Lūdzu ievadiet telefona platumu, cm: ");
telephone.Width = decimal.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu ievadiet telefona augstumu, cm: ");
telephone.Height = decimal.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu ievadiet telefona garumu, cm: ");
telephone.Length = decimal.Parse(Console.ReadLine());

Console.WriteLine($"Informācijas par telefonu: \n" +
                    $"Telefona marka: {telephone.Brand} \n" +
                    $"Telefona modelis {telephone.Model} \n" +
                    $"Telefona dimensijas (platums, augstums, garums): {telephone.Width}cm; {telephone.Height}cm; {telephone.Length}cm.");

telephone.MakeCall();
telephone.SendMessage();

Console.WriteLine("----==== 2. uzdevums ====----");

Car car = new Car();

Console.WriteLine("Lūdzu ievadiet mašīnas marku: ");
car.Brand = Console.ReadLine();
Console.WriteLine("Lūdzu ievadiet mašīnas numurzīmi: ");
car.NumberPlate = Console.ReadLine();
Console.WriteLine("Lūdzu ievadiet mašīnas ātrumu: ");
car.Speed = int.Parse(Console.ReadLine());

Console.WriteLine($"Auto marka: {car.Brand}; numurzīme: {car.NumberPlate}; ātrums: {car.Speed}");

car.StartDrive();
car.IncreaseSpeed();
car.IncreaseSpeed();
car.IncreaseSpeed();
car.IncreaseSpeed();
car.IncreaseSpeed();
car.MakeSomeNoise();
car.StopCar();

Console.WriteLine("----==== 3. uzdevums ====----");

Console.WriteLine("Lūdzu ievadiet produkta augstumu, cm: ");
double productHeight = double.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu ievadiet produkta platumu, cm: ");
double productWidth = double.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu ievadiet produkta garumu, cm: ");
double productLength = double.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu ievadiet produkta svaru, kg: ");
double productWeight = double.Parse(Console.ReadLine());

Product product = new Product(productHeight, productWidth, productLength);

product.Weight = productWeight;

product.DisplayProductDetails();

//Try to update values; only weight is changeable
product.Weight = 800;

product.CreateProduct();

product.DisplayProductDetails();

Console.WriteLine("----==== 4. uzdevums ====----");

Console.WriteLine("Lūdzu ievadiet vārdu: ");
string name = Console.ReadLine();
Console.WriteLine("Lūdzu ievadiet uzvārdu: ");
string surname = Console.ReadLine();
Console.WriteLine("Lūdzu ievadiet dzimšanas datumu (DD/MM/GGGG): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu ievadiet savu hobiju: ");
string hobby = Console.ReadLine();
Console.WriteLine("Lūdzu ievadiet savu dzimumu (S/V): ");
string gender = Console.ReadLine();

Person person = new Person(name, surname, birthDate, gender);

person.Hobby = hobby;

Console.WriteLine($"Vārds: {person.Name}; uzvārds: {person.Surname}; dzimšanas datums: {person.DateOfBirth}; hobijs {person.Hobby}; dzimums: {gender}");

person.Greeting();
person.CalculateAge();