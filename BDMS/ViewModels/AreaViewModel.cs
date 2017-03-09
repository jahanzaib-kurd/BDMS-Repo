using BDMS.Commands;
using BusinessModels;
using System.Windows.Input;

namespace BDMS.ViewModels
{
class AreaViewModel
{
    private AreaModel area;
    //private CustomerInfoViewModel infoVM;
    public ICommand UpdateCommand
    { 
        get;
        private set;
    }

    public AreaViewModel()
    {
        area = new AreaModel("Jahanzaib","acb");
        //infoVM = new CustomerInfoViewModel() { Info = "hello world" };
        UpdateCommand = new AreaUpdateCommand(this);
    }

    public AreaModel Area
    {
        get{ return area;}
    }

    public void SaveChanges()
    {
        //CustomerInfo view = new CustomerInfo();
        //view.DataContext = infoVM;
        //infoVM.Info = Customer.Name + " was updated";
        //view.ShowDialog();
    }
}
}
