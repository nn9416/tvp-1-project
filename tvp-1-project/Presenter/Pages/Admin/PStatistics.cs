using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tvp_1_project.Model;
using tvp_1_project.View.Pages.Admin;

namespace tvp_1_project.Presenter.Pages.Admin
{
    public class PStatistics
    {
        private readonly IStatisticsView _view;
        private readonly IDataRepository _repository;

        public PStatistics(IStatisticsView view, IDataRepository repository)
        {
            _view = view;
            _repository = repository;
            view.Presenter = this;
        }
    }
}
