namespace MVC.Views.ViewsData
{
    public class CompanyInformationViewData
    {
        private string companyName;
        public string CompanyName => companyName;
        private SectionInformationViewData[] companySectionsInformationViewDatas;

        public SectionInformationViewData[] CompanySectionsInformationViewDatas => companySectionsInformationViewDatas;

        public CompanyInformationViewData(string companyName,SectionInformationViewData[] companySectionsInformationViewDatas)
        {
            this.companyName = companyName;
            this.companySectionsInformationViewDatas = companySectionsInformationViewDatas;
        }
    }
}
