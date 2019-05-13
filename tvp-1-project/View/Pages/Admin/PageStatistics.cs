using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tvp_1_project.Presenter.Pages.Admin;

namespace tvp_1_project.View.Pages.Admin
{
    public partial class PageStatistics : UserControl, IStatisticsView
    {
        public PageStatistics()
        {
            InitializeComponent();
        }

        #region IStatisticsView
        public PStatistics Presenter { get; set; }
        #endregion
    }
}
