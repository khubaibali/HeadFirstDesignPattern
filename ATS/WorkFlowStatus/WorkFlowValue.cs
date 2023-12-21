namespace ATS.WorkFlowStatus;

public sealed class WorkFlowValue
{
    public readonly string StatusEn;
    public readonly string StatusAr;
    public readonly int Order;

    public WorkFlowValue(string statusEn,string statusAr, int order)
    {
       this.StatusEn = statusEn;
       this.StatusAr = statusAr;
       this.Order = order;
    }
}
