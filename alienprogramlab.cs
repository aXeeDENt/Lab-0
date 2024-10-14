namespace Lab_0
{
    public class AlienClass
    {
        public bool IsHuman { get; set; }
        public string Planet { get; set; }
        public int Age { get; set; }
        public List<string> Traits { get; set; }
        public AlienClass(bool isHuman, string planet, int age, List<string> traits)
        {
            IsHuman = isHuman;
            Planet = planet;
            Age = age;
            Traits = traits;
        }
    }
}