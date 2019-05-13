using System.Collections.Generic;
using tvp_1_project.Model;
using tvp_1_project.Presenter.Pages.Admin;

namespace tvp_1_project.View.Pages.Admin
{
    public interface ICarsView
    {
        PCars Presenter { get; set; }
        void PopulateDataViewer(List<Car> data);
        void UpdateDataViewer(List<Car> data);
    }
}
