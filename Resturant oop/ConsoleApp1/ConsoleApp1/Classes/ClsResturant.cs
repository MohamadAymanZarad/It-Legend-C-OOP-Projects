
namespace ResturantApp_oop.Classes;

internal class ClsResturant : ClsUser , IRepository<ClsResturant>
{
    #region Properties
    public string Logo { get; set; }= string.Empty;
    public string TaxCard { get; set; }= string.Empty;
    public string TelePhone { get; set; } = string.Empty;
    #endregion

    #region Methods
    public override void ShowOrders()
    {
        Console.WriteLine("Showing restaurant orders...");
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Logo: {Logo}, TaxCard: {TaxCard}, TelePhone: {TelePhone}");
    }
    public void ApproveOrder()
    {
        Console.WriteLine("Order approved by the restaurant.");
    }
    public void DeliverOrder()
    {
        Console.WriteLine("Order delivered by the restaurant.");
    }

    public List<ClsResturant> GetAll()
    {
        throw new NotImplementedException();
    }

    public ClsResturant GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Add(ClsResturant enitty)
    {
        throw new NotImplementedException();
    }

    public bool Edit(ClsResturant enitty)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }


    #endregion
}
