namespace MVC.Views.ViewsData
{
    public class CompanyInformationViewData
    {
        private SectionInformationViewData[] companySectionsInformationViewDatas;

        public SectionInformationViewData[] CompanySectionsInformationViewDatas => companySectionsInformationViewDatas;

        public CompanyInformationViewData(SectionInformationViewData[] companySectionsInformationViewDatas)
        {
            this.companySectionsInformationViewDatas = companySectionsInformationViewDatas;
        }
    }
}
