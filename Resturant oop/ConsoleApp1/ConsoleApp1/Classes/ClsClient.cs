
namespace ResturantApp_oop.Classes;

public class ClsClient : ClsUser , IRepository<ClsClient>
{
    #region Properties
    public int FlatNo { get; set; }
    public int FloorNo { get; set; }
    public string SecondPhone { get; set; } = string.Empty;

    public double DeliverLocation { get; set; }
    #endregion

    #region Methods
    public void SendOrder()
    {
        Console.WriteLine("Order sent to the restaurant.");
    }
    public void ReceivedOrder()
    {
        Console.WriteLine("Order received by the client.");
    }
    public override void ShowOrders()
    {
        Console.WriteLine("Showing client orders...");
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Flat: {FlatNo}, Floor: {FloorNo}, Second Phone: {SecondPhone}, Delivery Location: {DeliverLocation}");
    }

    public List<ClsClient> GetAll()
    {
        throw new NotImplementedException();
    }

    public ClsClient GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Add(ClsClient enitty)
    {
        throw new NotImplementedException();
    }

    public bool Edit(ClsClient enitty)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public ClsClient (int FlatNo)
    {
    }
    public ClsClient()
    {
        this.FlatNo = FlatNo;
        this.FloorNo = FloorNo;
        this.SecondPhone = SecondPhone;
        this.DeliverLocation = DeliverLocation;
    }
    #endregion
}
