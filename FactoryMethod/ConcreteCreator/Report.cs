namespace FactoryMethod
{
    public class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new ReportPage());
            Pages.Add(new ReportPage());
            Pages.Add(new ReportPage());
        }
    }
}