namespace ATS.WorkFlowStatus;

public static partial class WorkFlow
{
    public static class JobRequestWorkFlow
    {
        public static WorkFlowValue NewRequisitionSLApproval = new("Awaiting Second Line Manager's Approval", "بانتظار موافقة المدير", 1);
        public static WorkFlowValue UpdatedRequisitionSLApproval = new("Awaiting Second Line Manager's Approval", "بانتظار موافقة المدير", 2);
        public static WorkFlowValue RequisitionSLReqForReSubmit = new("Second Line Manager Requested for Modification", "بانتظار موافقة المدير", 3);
        public static WorkFlowValue RequisitionSLRejected = new("Rejected By Second Line Manager", "بانتظار موافقة المدير", 4);
        public static WorkFlowValue NewRequisitionODApproval = new("Awaiting OD's Approval", "بانتظار موافقة المدير", 5);
        public static WorkFlowValue UpdatedRequisitionODApproval = new("Awaiting Second Line Manager's Approval", "بانتظار موافقة المدير", 6);
        public static WorkFlowValue RequisitionODReqForReSubmit = new("Awaiting OD's Approval", "بانتظار موافقة المدير", 7);
        public static WorkFlowValue RequisitionODRejected = new("Rejected By OD", "بانتظار موافقة المدير", 8);
        public static WorkFlowValue NewRequisitionFinanceApproval = new("Awaiting Finance Approval", "بانتظار موافقة المدير", 9);
        public static WorkFlowValue UpdatedRequisitionFinanceApproval = new("Awaiting Finance Approval", "بانتظار موافقة المدير", 10);
        public static WorkFlowValue RequisitionFinanceReqForReSubmit = new("Finance Requested for Modification", "بانتظار موافقة المدير", 11);
        public static WorkFlowValue RequisitionFinanceRejected = new("Rejected By Finance", "بانتظار موافقة المدير", 12);
        public static WorkFlowValue NewRequisitionHRDApproval = new("Awaiting HR Director's Approval", "بانتظار موافقة المدير", 13);
        public static WorkFlowValue UpdatedRequisitionHRDApproval = new("Awaiting HR Director's Approval", "بانتظار موافقة المدير", 14);
        public static WorkFlowValue RequisitionHRDReqForReSubmit = new("HR Director Requested For Modification", "بانتظار موافقة المدير", 15);
        public static WorkFlowValue RequisitionHRDRejected = new("Rejected By HR Director", "بانتظار موافقة المدير", 16);
        public static WorkFlowValue RequisitionPendingOnRecHead = new("Awaiting Head of Recruitment's Action", "بانتظار موافقة المدير", 17);
        public static WorkFlowValue RequisitionPendingOnRec = new("Pending On Recruiter", "بانتظار موافقة المدير", 18);

    }
}
