namespace MVC.Views.ViewsData
{
    public class CompanyInformationViewData
    {
        private SectionInformationViewData[] companySectionsInformationViewDatas;

        SectionInformationViewData[] CompanySectionsInformationViewDatas => companySectionsInformationViewDatas;

        public CompanyInformationViewData(SectionInformationViewData[] companySectionsInformationViewDatas)
        {
            this.companySectionsInformationViewDatas = companySectionsInformationViewDatas;
        }
    }
}
