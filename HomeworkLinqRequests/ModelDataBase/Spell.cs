namespace HomeworkLinqRequests.ModelDataBase
{
    public class Spell
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public Spell(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
