namespace HomeworkLinqRequests.ModelDataBase
{
    public class Characters
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public int CharacterClassId { get; private set; }

        public Characters(int id, string name, int characterClassId)
        {
            Id = id;
            Name = name;
            CharacterClassId = characterClassId;
        }
    }
}
