namespace HomeworkLinqRequests.ModelDataBase
{
    public class CharacterClassBuild
    {
        public int Id { get; private set; }

        public int CharacterClassId { get; private set; }

        public int SpellId { get; private set; }

        public CharacterClassBuild(int id, int characterClassId, int spellId)
        {
            Id = id;
            CharacterClassId = characterClassId;
            SpellId = spellId;
        }
    }
}
