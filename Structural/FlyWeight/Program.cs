namespace FlyWeight
{
    internal static class Program
    {
        private static void Main()
        {
            char[] chars = "AABBAB".ToCharArray();
            CharacterFactory factory = new();
            int pointSize = 10;

            foreach (var myChar in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(myChar);
                character.Display(pointSize);
            }
        }
    }
}