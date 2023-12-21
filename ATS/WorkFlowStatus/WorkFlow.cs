﻿using System.IO;

namespace ATS.WorkFlowStatus;

public static class WorkFlow
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
    public static class JobPost
    {
        public static WorkFlowValue NewJobPostHRDApproval = new WorkFlowValue("Awaiting HR Director's Approval", "Awaiting HR Director's Approval",20);
        public static WorkFlowValue UpdatedJobPostHRDApproval = new WorkFlowValue("Awaiting HR Director's Approval", "Awaiting HR Director's Approval", 21);
        public static WorkFlowValue JobPostHRDReqForReSubmit = new WorkFlowValue("HR Director Requested For Modification", "HR Director Requested For Modification", 22);
        public static WorkFlowValue JobPostHRDApproved = new WorkFlowValue("Approved & Ready for Publish", "Approved & Ready for Publish", 23);
        public static WorkFlowValue JobPostPublishToIntranet = new WorkFlowValue("Published for Internal Employees", "Published",24);
        public static WorkFlowValue JobPostPublishToCareerPortal = new WorkFlowValue("Published", "Published", 25);
    }
    public static class ApplicantWorkFlow
    {
        public static WorkFlowValue WithdrawApplication = new ("Withdrawn", "Withdrawn",1);
        public static WorkFlowValue LMInterviewAccepted = new ("LM Accepted", "LM Accepted",2);
        public static WorkFlowValue JobAppRejectedByHR = new ("Rejected", "Rejected",3);
        public static WorkFlowValue ApplicationReceived = new ("Application Received", "Application Received",4);
        public static WorkFlowValue FirstShortListed = new ("Shortlisted", "Shortlisted",5);
        public static WorkFlowValue SharedWithLineManager = new ("Shared with Line Manager", "Shared with Line Manager",6);
        public static WorkFlowValue LMRequestedToScheduleInterview = new ("LM Request to Schedule", "LM Request to Schedule",7);
        public static WorkFlowValue LMRequestedToSendAssignment = new ("Requested To Send Assignment", "Requested To Send Assignment",8);
        public static WorkFlowValue JobAppRejectedByLM = new ("Rejected Profile", "Rejected Profile",9);
        public static WorkFlowValue RecInterviewAccepted = new ("Awaiting For Applicant Response", "Awaiting For Applicant Response",10);
        public static WorkFlowValue RecAssignmentPhysicalSent = new ("Assignment Sent To Applicant", "Assignment Sent To Applicant",11);
        public static WorkFlowValue RecAssignmentPhysicalSch = new ("In-House Assignment Scheduled", "In-House Assignment Scheduled",12);
        public static WorkFlowValue RecAssignmentSent = new ("Assignment Under Process", "Assignment Under Process",13);
        public static WorkFlowValue AppAssignmentSubmitted = new ("Assignment Submitted", "Assignment Submitted",14);
        public static WorkFlowValue LMRequestedToReScheduleInterview = new ("LM Request to Re-schedule", "LM Request to Re-schedule",15);
        public static WorkFlowValue LMAssignmentAssessProceedBI = new ("Proceed", "Proceed",16);
        public static WorkFlowValue RecInterviewReSchAccepted = new ("Recruiter Rescheduled", "Recruiter Rescheduled",17);
        public static WorkFlowValue LMInterviewCancel = new ("LM Interview Cancel", "LM Interview Cancel",18);
        public static WorkFlowValue RecInterviewCancel = new ("Rec Interview Cancel", "Rec Interview Cancel",19);
        public static WorkFlowValue AppInterviewAccepted = new ("Accepted By Applicant", "Accepted By Applicant",20);
        public static WorkFlowValue AppInterviewReqForReSchedule = new ("Applicant Requested Reschedule", "Applicant Requested Reschedule",21);
        public static WorkFlowValue AppInterviewRejected = new ("Applicant Interview Rejected", "Applicant Interview Rejected",22);
        public static WorkFlowValue LMInterviewAssessProceed = new ("Proceed", "Proceed",23);
        public static WorkFlowValue LMInterviewAssessReject = new ("Reject", "Reject",24);
        public static WorkFlowValue LMInterviewAssessOnHold = new ("On Hold", "On Hold",25);
        public static WorkFlowValue RecInterviewAssessProceed = new ("Proceed", "Proceed",26);
        public static WorkFlowValue RecInterviewAssessReject = new ("Reject", "Reject",27);
        public static WorkFlowValue RecInterviewAssessOnHold = new ("On Hold", "On Hold",28);
        public static WorkFlowValue LMAssignmentAssessProceed = new ("Shortlisted", "Shortlisted",29);
        public static WorkFlowValue LMAssignmentAssessReject = new ("Reject", "Reject",30);
        public static WorkFlowValue LMAssignmentAssessOnHold = new ("On-Hold", "On-Hold",31);
        public static WorkFlowValue RecAppDocumentsRequested = new ("Documents Requested", "Documents Requested",32);
        public static WorkFlowValue AppJobDocumentsSubmitted = new ("Documents Submitted", "Documents Submitted",33);
        public static WorkFlowValue RecAppDocumentsRequestedAgain = new ("Documents Requested Again", "Documents Requested Again",34);
        public static WorkFlowValue RecAppDocumentsApproved = new ("Pending on External Approval", "Pending on External Approval",35);
        public static WorkFlowValue AppFinalShortListed = new ("Final ShortListed", "Final ShortListed",36);
        public static WorkFlowValue NewInitOfferRecHeadApproval = new ("Initial Offer Head of Recruitment's Approval", "Initial Offer Head of Recruitment's Approval",37);
        public static WorkFlowValue UpdatedInitOfferRecHeadApproval = new ("Initial Offer Head of Recruitment's Approval", "Initial Offer Head of Recruitment's Approval",38);
        public static WorkFlowValue InitOfferRecHeadReqForReSubmit = new ("HR Director Requested For Modification", "HR Director Requested For Modification",39);
        public static WorkFlowValue NewInitOfferHRDApproval = new ("Initial Offer HR Director's Approval", "Initial Offer HR Director's Approval",40);
        public static WorkFlowValue UpdatedInitOfferHRDApproval = new ("Initial Offer HR Director's Approval", "Initial Offer HR Director's Approval",41);
        public static WorkFlowValue InitOfferHRDReqForReSubmit = new ("HR Director Requested For Modification", "HR Director Requested For Modification",42);
        public static WorkFlowValue NewInitOfferExecDApproval = new ("Initial Offer Executive Director's Approval", "Initial Offer Executive Director's Approval",43);
        public static WorkFlowValue UpdatedInitOfferExecDApproval = new ("Initial Offer Executive Director's Approval", "Initial Offer Executive Director's Approval",44);
        public static WorkFlowValue InitOfferExecDReqForReSubmit = new ("Executive Director Requested For Modification", "Executive Director Requested For Modification",45);
        public static WorkFlowValue InitOfferExecDApproved = new ("Executive Director Approved", "Executive Director Approved",46);
        public static WorkFlowValue RecOfferSharedWithApp = new ("Initial Offer Shared", "Initial Offer Shared",47);
        public static WorkFlowValue AppOfferProposalAccepted = new ("App Initial Offer Accepted", "App Initial Offer Accepted",48);
        public static WorkFlowValue AppOfferProposalRejected = new ("App Initial Offer Rejected", "App Initial Offer Rejected",49);
        public static WorkFlowValue RecMedicalCertRequestedFromApp = new ("Medical Certificate Requested", "Medical Certificate Requested",50);
        public static WorkFlowValue RecMedicalCertReqAgainFromApp = new ("Medical Certificate Again Requested", "Medical Certificate Again Requested",51);
        public static WorkFlowValue AppMedicalDocSubmitted = new ("Medical Certificate Submitted", "Medical Certificate Submitted",52);
        public static WorkFlowValue RecAppMedicalCertApproved = new ("Medical Certificate Approved", "Medical Certificate Approved",53);
        public static WorkFlowValue RecFinalOfferSharedWithApp = new ("Final Offer Shared", "Final Offer Shared",54);
        public static WorkFlowValue AppFinalOfferAccepted = new ("App Final Offer Accepted", "App Final Offer Accepted",55);
        public static WorkFlowValue AppFinalOfferRejected = new ("App Final Offer Rejected", "App Final Offer Rejected",56);
        public static WorkFlowValue NewEmpContractRecHeadApproval = new ("Emp Contract Head of Recruitment's Approval", "Emp Contract Head of Recruitment's Approval",57);
        public static WorkFlowValue UpdatedEmpContractRecHeadApproval = new ("Emp Contract Head of Recruitment's Approval", "Emp Contract Head of Recruitment's Approval",58);
        public static WorkFlowValue EmpContractRecHeadReqForReSubmit = new ("HR Director Requested For Modification", "HR Director Requested For Modification",59);
        public static WorkFlowValue NewEmpContractHRDApproval = new ("Emp Contract HR Director's Approval", "Emp Contract HR Director's Approval",60);
        public static WorkFlowValue UpdatedEmpContractHRDApproval = new ("Emp Contract HR Director's Approval", "Emp Contract HR Director's Approval",61);
        public static WorkFlowValue EmpContractHRDReqForReSubmit = new ("HR Director Requested For Modification", "HR Director Requested For Modification",62);
        public static WorkFlowValue NewEmpContractExecDApproval = new ("Emp Contract Executive Director's Approval", "Emp Contract Executive Director's Approval",63);
        public static WorkFlowValue UpdatedEmpContractExecDApproval = new ("Emp Contract Executive Director's Approval", "Emp Contract Executive Director's Approval",64);
        public static WorkFlowValue EmpContractExecDReqForReSubmit = new ("Executive Director Requested For Modification", "Executive Director Requested For Modification",65);
        public static WorkFlowValue EmpContractExecDApproved = new ("Emp Contract Approved by Executive Director", "Emp Contract Approved by Executive Director",66);
        public static WorkFlowValue RecAskBiographyWithApp = new ("Recruiter Asked Biography", "Recruiter Asked Biography",67);
        public static WorkFlowValue RecAskAgainBiographyWithApp = new ("Recruiter Asked Biography Again", "Recruiter Asked Biography Again",68);
        public static WorkFlowValue AppBiographySubmitted = new ("Biography Submitted", "Biography Submitted",69);
        public static WorkFlowValue RecBiographyApproved = new ("Biography Approved", "Biography Approved",70);
        public static WorkFlowValue NewEmployeeOnBoarded = new ("New Employee On Boarded", "New Employee On Boarded",71);
        public static WorkFlowValue RecConformationSent = new("Confirmation Shared", "Confirmation Shared",72);
    }
}