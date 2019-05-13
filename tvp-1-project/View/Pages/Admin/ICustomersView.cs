using System.Collections.Generic;
using tvp_1_project.Model;
using tvp_1_project.Presenter.Pages.Admin;

namespace tvp_1_project.View.Pages.Admin
{
    public interface ICustomersView
    {
        PCustomers Presenter { get; set; }
        void PopulateDataViewer(List<Customer> data);
        void UpdateDataViewer(List<Customer> data);
    }
}
