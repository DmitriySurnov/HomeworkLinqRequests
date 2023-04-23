using HomeworkLinqRequests.ModelDataBase;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkLinqRequests
{
    internal static class Requests 
    {
        public static List<string> NameOfPlayers(DataBase db)
        {
            return db.Characters.Select(x => x.Name).ToList();
        }

        private static List<string[]> Conversion(List<(string value1, string value2)> values)
        {
            List<string[]> listString = new List<string[]>();
            foreach ((string value1, string value2) in values)
            {
                listString.Add(new string[2]);
                listString[listString.Count - 1][0] = value1;
            
                listString[listString.Count - 1][1] = value2;
            }
            return listString;
        }

        public static List<string[]> NameOfPlayersAndNameOfClass(DataBase db)
        {
            return Conversion(
                db.Characters.Select(x => (x.Name,
                     db.CharactersClass.First(y => y.Id == x.CharacterClassId).Name))
                .ToList()
                );
        }

        public static List<string[]> NameOfPlayersAndNameOfSpell(DataBase db)
        {
            return Conversion(
                db.CharacterClassBuild.Select(x => (
                     db.Characters.First(z => z.CharacterClassId == 
                        db.CharactersClass.First(y => x.CharacterClassId == y.Id).Id).Name,
                     db.Spell.First(y => y.Id == x.CharacterClassId).Name))
                .ToList()
                );
        }

        public static List<string[]> NameOfClassAndNameOfSpell(DataBase db)
        {
            return Conversion(
                db.CharacterClassBuild.Select(x => (
                     db.CharactersClass.First(y => x.CharacterClassId == y.Id).Name,
                     db.Spell.First(y => y.Id == x.CharacterClassId).Name))
                .ToList()
                );
        }
    }
}
