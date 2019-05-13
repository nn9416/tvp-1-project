using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tvp_1_project.Presenter.Pages.Admin;

namespace tvp_1_project.View.Pages.Admin
{
    public interface IStatisticsView
    {
        PStatistics Presenter { get; set; }
    }
}
