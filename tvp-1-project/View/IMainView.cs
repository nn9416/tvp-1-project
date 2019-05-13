using System.Collections.Generic;
using System.Windows.Forms;
using tvp_1_project.Presenter;

namespace tvp_1_project.View
{
    public interface IMainView
    {
        PMain Presenter { get; set; }
        Dictionary<string, UserControl> Pages { get; set; }
        void SetViewState(bool isAdmin);
    }
}
