namespace MVC.Models.ModelsData
{
    public class ActualSalariesModelData 
    {
        private string sectionName;
        private float[] actualSalariesArray;

        public string SectionName => sectionName;
        public float[] ActualSalariesArray => actualSalariesArray;

        public ActualSalariesModelData(string sectionName, float[] actualSalariesArray )
        {
            this.sectionName = sectionName;
            this.actualSalariesArray = actualSalariesArray;
        }
    }
}
