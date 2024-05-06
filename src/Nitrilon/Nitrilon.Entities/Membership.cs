namespace Nitrilon.Entities
{
    public class Membership 
    {
        private int id;
        private string name;
        private string description;

        public Membership(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
    }
}
