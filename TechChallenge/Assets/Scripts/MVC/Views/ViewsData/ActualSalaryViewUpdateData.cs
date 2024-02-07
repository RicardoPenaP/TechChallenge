namespace MVC.Views.ViewsData
{
    public class ActualSalaryViewUpdateData
    {
        private string sectionName;
        private string[] actualSalariesArray;

        public string SectionName => sectionName;
        public string[] ActualSalariesArray => actualSalariesArray;

        public ActualSalaryViewUpdateData(string sectionName, string[] actualSalariesArray)
        {
            this.sectionName = sectionName;
            this.actualSalariesArray = actualSalariesArray;
        }
    }
}
