namespace HomeworkLinqRequests.ModelDataBase
{
    public class CharactersClass
    {
        public int Id { get; private set; }

        public string NameClass { get; private set; }

        public CharactersClass(int id, string nameClass)
        {
            Id = id;
            NameClass = nameClass;
        }
    }
}
