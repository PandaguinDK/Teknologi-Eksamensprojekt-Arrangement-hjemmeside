namespace Teknologi_Eksamensprojekt.Data
{
    public class Arrangement
    {
        public Arrangement(string name, DateTime date, string description)
        {
            this.Name = name;
            this.Date = date;
            this.Description = description;
        }

        public string Name { get; set; }
        DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
