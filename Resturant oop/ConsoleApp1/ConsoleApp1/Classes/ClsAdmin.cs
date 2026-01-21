
namespace ResturantApp_oop.Classes;

public class ClsAdmin : ClsUser , IRepository<ClsAdmin>
{
    #region Properties
    public string JobName { get; set; } = string.Empty; 
    #endregion

    #region Methods
    public override void ShowOrders()
    {
        Console.WriteLine("Showing admin orders...");
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Job Name: {JobName}");
    }
    public void CancelOrder()
    {
        Console.WriteLine("Order canceled by the admin.");
    }

    public void ContactUser()
    {
        Console.WriteLine("Contacting user...");
    }

    public List<ClsAdmin> GetAll()
    {
        throw new NotImplementedException();
    }

    public ClsAdmin GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Add(ClsAdmin enitty)
    {
        throw new NotImplementedException();
    }

    public bool Edit(ClsAdmin enitty)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }
    #endregion
}
