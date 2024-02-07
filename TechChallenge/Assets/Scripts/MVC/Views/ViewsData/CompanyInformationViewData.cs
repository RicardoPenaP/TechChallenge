namespace MVC.Views.ViewsData
{
    public class CompanyInformationViewData
    {
        private string companyName;
        public string CompanyName => companyName;
        private SectionInformationViewData[] companySectionsInformationViewDatas;

        public SectionInformationViewData[] CompanySectionsInformationViewDatas => companySectionsInformationViewDatas;

        public CompanyInformationViewData(SectionInformationViewData[] companySectionsInformationViewDatas)
        {
            this.companySectionsInformationViewDatas = companySectionsInformationViewDatas;
        }
    }
}
