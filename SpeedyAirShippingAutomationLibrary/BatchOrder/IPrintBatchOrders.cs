
namespace SpeedyAirShippingAutomationLibrary.BatchOrder
{
    public interface IPrintBatchOrders
    {
        void Print(List<IBatchOrderModel> batchOrders);
    }
}