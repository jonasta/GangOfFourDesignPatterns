using System.Collections.Generic;

namespace FlyWeight
{
    public class CharacterFactory
    {
        private readonly Dictionary<char, Character> Characters = new();

        public CharacterFactory()
        {
            Characters.Add('A', new CharacterA());
            Characters.Add('B', new CharacterB());
        }

        internal Character GetCharacter(char key)
        {
            return Characters[key];
        }
    }
}