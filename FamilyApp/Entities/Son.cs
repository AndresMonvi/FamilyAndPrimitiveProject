
namespace FamilyApp.Entities
{
    internal class Son : Father
    {
        public string Pet { get; set; }
        protected decimal Height { get; set; }
        private decimal Weight { get; set; }

        public Son()
        {
            this.Name = "Francisco";
            this.Age = 52;
            SetDni("12345678A");
            this.Car = "Mercedes";
            this.Profession = "Teacher";
            SetChildren(2);
            Pet = "None";
            Height = 1.82m;
            Weight = 75m;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Edad: {Age}");
            Console.WriteLine($"Dni: {GetDni()}");
            Console.WriteLine($"Coche: {Car}");
            Console.WriteLine($"Profesion: {Profession}");
            Console.WriteLine($"Hijos: {GetChilden()}");
            Console.WriteLine($"Mascotas: {Pet}");
            Console.WriteLine($"Altura: {Height}");
            Console.WriteLine($"Peso: {Weight}");
        }

        public void SetHeight(string Height)
        {

            bool correctFormat = Decimal.TryParse(Height, out decimal result);
            if (correctFormat)
            {
                this.Height = result;
            }
            else
            {
                Console.WriteLine("Problems with input");
            }
        }

        public void SetWeight(string Weight)
        {

            bool correctFormat = Decimal.TryParse(Weight, out decimal result);
            if (correctFormat)
            {
                this.Weight = result;
            }
            else
            {
                Console.WriteLine("Problems with input");
            }
        }
    }
}
