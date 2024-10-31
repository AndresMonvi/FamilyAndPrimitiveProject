
namespace FamilyApp.Entities
{
    internal class Grandfather
    {
        public string Name { get; set; }
        protected int Age { get; set; }
        private string Dni;

        public string GetDni()
        {
            return Dni;
        }

        public void SetDni(string Dni)
        {
            this.Dni = Dni;
        }

        public void SetAge(int Age)
        {
            this.Age = Age;
        }
    }
}
