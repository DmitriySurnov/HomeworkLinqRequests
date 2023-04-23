namespace HomeworkLinqRequests.ModelDataBase
{
    public class CharactersClass
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public CharactersClass(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
