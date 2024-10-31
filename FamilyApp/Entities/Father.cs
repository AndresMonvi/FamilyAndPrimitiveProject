
namespace FamilyApp.Entities
{
    internal class Father : Grandfather
    {
        public string Car { get; set; }
        protected string Profession { get; set; }
        private int Children;


        public int GetChilden()
        {
            return Children;
        }

        public void SetChildren(int Children)
        {
            this.Children = Children;
        }

        public void SetProfession(string Profession)
        {
            this.Profession = Profession;
        }
    }
}
