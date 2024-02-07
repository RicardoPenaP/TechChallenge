namespace MVC.Models.ModelsData
{
    public class UpdatedSalariesModelData 
    {
        private string sectionName;
        private float[] actualSalariesArray;

        public string SectionName => sectionName;
        public float[] ActualSalariesArray => actualSalariesArray;

        public UpdatedSalariesModelData(string sectionName, float[] actualSalariesArray )
        {
            this.sectionName = sectionName;
            this.actualSalariesArray = actualSalariesArray;
        }
    }
}
