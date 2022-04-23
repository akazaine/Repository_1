namespace majasDarbs3
{
    public class Telephone
    {    
        public string Brand { get; set; }
        public string Model { get; set; }

        //Dimentions

        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }


        public void MakeCall()
        {
            Console.WriteLine($"Piezvanīsim kādam!");
        }

        public void SendMessage()
        {
            Console.WriteLine($"Nosūtīsim ziņu!");
        }
    }
}
