namespace Lab_0
{
    public class AlienClass
    {
        public int Id { get; set; }
        public bool IsHuman { get; set; }
        public string Planet { get; set; }
        public int Age { get; set; }
        public List<string> Traits { get; set; }
        public AlienClass(int id, bool isHuman, string planet, int age, List<string> traits)
        {
            Id = id;
            IsHuman = isHuman;
            Planet = planet;
            Age = age;
            Traits = traits;
        }
    }
}