namespace majasDarbs3
{
    public class Product
    {
        public Product(double height, double width, double lenght)
        {
            Height = height;
            Width = width;
            Lenght = lenght;
        }
        public double Height { get;}
        public double Width { get; }
        public double Lenght { get; }
        public double Weight { get; set; }

        public void CreateProduct()
        {
            Console.WriteLine("Prece izveidota!");
        }

        public void DisplayProductDetails()
        {
            Console.WriteLine($"Produkta augstums: {Height}; platums: {Width}; garums: {Lenght}; svars: {Weight}");
        }

    }
}
