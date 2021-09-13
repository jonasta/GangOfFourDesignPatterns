namespace FactoryMethod
{
    public class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new ExperiencePage());
            Pages.Add(new EducationPage());
        }
    }
}