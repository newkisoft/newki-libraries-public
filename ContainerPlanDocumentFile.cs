
namespace newkilibraries
{
    public class ContainerPlanDocumentFile
    {
        public ContainerPlanDocumentFile()
        {
        }
        public int DocumentFileId {get;set;}
        public int ContainerPlanId{get;set;}

        public ContainerPlan ContainerPlan {get;set;}
        public DocumentFile File{get;set;}
    }
}
