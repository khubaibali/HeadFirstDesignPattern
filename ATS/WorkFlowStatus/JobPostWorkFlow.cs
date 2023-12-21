namespace ATS.WorkFlowStatus;

public static partial class WorkFlow
{
    public static class JobPost
    {
        public static WorkFlowValue NewJobPostHRDApproval = new WorkFlowValue("Awaiting HR Director's Approval", "Awaiting HR Director's Approval", 20);
        public static WorkFlowValue UpdatedJobPostHRDApproval = new WorkFlowValue("Awaiting HR Director's Approval", "Awaiting HR Director's Approval", 21);
        public static WorkFlowValue JobPostHRDReqForReSubmit = new WorkFlowValue("HR Director Requested For Modification", "HR Director Requested For Modification", 22);
        public static WorkFlowValue JobPostHRDApproved = new WorkFlowValue("Approved & Ready for Publish", "Approved & Ready for Publish", 23);
        public static WorkFlowValue JobPostPublishToIntranet = new WorkFlowValue("Published for Internal Employees", "Published", 24);
        public static WorkFlowValue JobPostPublishToCareerPortal = new WorkFlowValue("Published", "Published", 25);
    }
}
