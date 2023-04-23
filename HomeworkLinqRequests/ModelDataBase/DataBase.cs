using System.Collections.Generic;

namespace HomeworkLinqRequests.ModelDataBase
{
    public class DataBase
    {
        public List<Characters> Characters { get; private set; }

        public List<CharactersClass> CharactersClass { get; private set; }

        public List<Spell> Spell { get; private set; }

        public List<CharacterClassBuild> CharacterClassBuild { get; private set; }


        public DataBase()
        {
            Characters = new List<Characters>();
            CharactersClass = new List<CharactersClass>();
            Spell = new List<Spell>();
            CharacterClassBuild = new List<CharacterClassBuild>();
        }

        public void InitStaticDb()
        {
            Characters.Add(new Characters(1, "Первый", 1));
            Characters.Add(new Characters(2, "Втрой", 2));
            CharactersClass.Add(new CharactersClass(1,"Лучник"));
            CharactersClass.Add(new CharactersClass(2, "Маг"));
            Spell.Add(new Spell(1, "Удар"));
            Spell.Add(new Spell(2, "Волшебный удар"));
            CharacterClassBuild.Add(new CharacterClassBuild(1,1,1));
            CharacterClassBuild.Add(new CharacterClassBuild(2, 2, 1));
            CharacterClassBuild.Add(new CharacterClassBuild(2, 2, 2));
        }
    }
}
