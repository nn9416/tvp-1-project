using System.Drawing;
using System.Windows.Forms;

namespace tvp_1_project.BussinesLogic
{
    public static class ResponsiveLayout
    {
        public static void ChangeSize(Control control, Size size, int widthOffset = 0, int heightOffset = 0)
        {
            ChangeWidth(control, size.Width, widthOffset);
            ChangeHeight(control, size.Height, heightOffset);
        }

        public static void ChangeWidth(Control control, int parentWidth, int offset = 0)
        {
            control.Width = parentWidth - offset;
        }

        public static void ChangeHeight(Control control, int parentHeight, int offset = 0)
        {
            control.Height = parentHeight - offset;
        }
    }
}
