namespace ChuckSwapi.Entities
{
    public abstract class BasePeople
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string HairColor { get; set; }
        public string SkinColor { get; set; }
        public string EyeColor { get; set; }
        public string BirthYear { get; set; }
        public string Gender { get; set; }
        public string HomeWorld { get; set; }
       
        public string Url { get; set; }
    }
}
