namespace FlyWeight
{
    public abstract class Character
    {
        protected char Symbol;
        protected int PointSize;

        public abstract void Display(int pointSize);
    }
}