namespace HomeworkLinqRequests.ModelDataBase
{
    public class Spell
    {
        public int Id { get; private set; }

        public string NameSpell { get; private set; }

        public Spell(int id, string nameSpell)
        {
            Id = id;
            NameSpell = nameSpell;
        }
    }
}
