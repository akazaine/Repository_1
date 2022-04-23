namespace majasDarbs3
{
    public class Car
    {
        public string Brand { get; set; }
        public string NumberPlate { get; set; }
        public int Speed { get; set; }

        public void StartDrive()
        {
              Console.WriteLine($"Uzsāksim braukt ar {Brand} markas auto ar numurzīmi {NumberPlate} ar ātrumu {Speed}km/h!");
        }

        public void IncreaseSpeed()
        {
            Speed += 5;
            Console.WriteLine($"Palielināsim ātrumu līdz {Speed}km/h!");
        }

        public void StopCar()
        {
            Speed = 0;
            Console.WriteLine($"Apturiet {Brand} markas auto; ātrums = {Speed}km/h!");
        }

        public void MakeSomeNoise()
        {
            Console.WriteLine($"Mašīna {Brand} saka beep beep!");
        }

    }
}
