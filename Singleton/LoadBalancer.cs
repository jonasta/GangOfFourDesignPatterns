namespace Singleton
{
    public class LoadBalancer
    {
        private static LoadBalancer _instance;

        protected LoadBalancer()
        {
        }

        public static LoadBalancer Instance()
        {
            return _instance ??= new LoadBalancer();
        }
    }
}