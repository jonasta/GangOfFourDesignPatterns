namespace TemplateMethod
{
    public abstract class DataAcessor
    {
        protected abstract void AssembleList();

        protected abstract void ShowData();

        public void Run()
        {
            AssembleList();
            ShowData();
        }
    }
}