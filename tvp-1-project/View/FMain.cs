using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using tvp_1_project.BussinesLogic;
using tvp_1_project.Presenter;
using tvp_1_project.View.Pages.Admin;

namespace tvp_1_project.View
{
    public partial class FMain : Form, IMainView
    {
        public FMain()
        {
            InitializeComponent();
        }

        #region IMainView
        public PMain Presenter { get; set; }

        public Dictionary<string, UserControl> Pages { get; set; }

        public void SetViewState(bool isAdmin)
        {
            ucSideMenu.HideButtons(isAdmin);
            ucSideMenu.ButtonClick += UcSideMenu_ButtonClick;

            Pages = new Dictionary<string, UserControl>() {
                { "cars", CarsPage },
                { "customers", CustomersPage },
                { "offers", OffersPage },
                { "bookings", BookingsPage },
                //{ "statistics", StatisticsPage },
                //{ "currentBookings", CurrentBookingsPage},
                //{ "bookNew", BookNewPage}
            };

            string currentUserUsername = Authentication.CurrentUser;
            if (currentUserUsername.Equals("admin"))
            {
                currentUserLabel.Text = $"Admin Panel - Rent a Car";
            } else
            {
                currentUserLabel.Text = $"{currentUserUsername} - Rent a Car";
            }
            

            CarsPage.CrudButtonClick += UcDataView_CrudButtonClick;
            CustomersPage.CrudButtonClick += UcDataView_CrudButtonClick;
            OffersPage.CrudButtonClick += UcDataView_CrudButtonClick;

            if (isAdmin)
            {
                pagesPanel.Controls.Add(Pages["cars"] as UserControl);
                Pages["cars"].Dock = DockStyle.Fill;
            }
            //else
            //{
            //    pagesPanel.Controls.Add(Pages["currentBookings"] as UserControl);
            //    Pages["currentBookings"].Dock = DockStyle.Fill;
            //}
        }
        #endregion

        #region Events
        private void FMain_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void UcSideMenu_ButtonClick(object sender, EventArgs e)
        {
            string pageName = ((Button)sender).Tag.ToString();
            pagesPanel.Controls.Clear();
            pagesPanel.Controls.Add(Pages[pageName] as UserControl);
            Pages[pageName].Dock = DockStyle.Fill;
        }
         
        private void UcDataView_CrudButtonClick(object sender, CustomEventArgs e) => Presenter.PerformCRUD(((Button)sender).Tag.ToString(), e.Data);

        #region Form custom title bar events
        private void FMain_Resize(object sender, EventArgs e)
        {
            ResponsiveLayout.ChangeWidth(pagesPanel, ClientSize.Width, ucSideMenu.Width + 8);
            ResponsiveLayout.ChangeHeight(pagesPanel, ClientSize.Height, 39);
            ResponsiveLayout.ChangeHeight(ucSideMenu, pagesPanel.Height);

            if (this.WindowState == FormWindowState.Maximized)
            {
                maximizeLabel.Text = "⧉";
            }
            else
            {
                maximizeLabel.Text = "■";
            }
        }

        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinimizeLabel_MouseEnter(object sender, EventArgs e)
        {
            minimizeLabel.ForeColor = Color.FromArgb(137, 202, 120);
        }

        private void MinimizeLabel_MouseLeave(object sender, EventArgs e)
        {
            minimizeLabel.ForeColor = Color.White;
        }

        private void MaximizeLabel_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void MaximizeLabel_MouseEnter(object sender, EventArgs e)
        {
            maximizeLabel.ForeColor = Color.FromArgb(97, 175, 239);
        }

        private void MaximizeLabel_MouseLeave(object sender, EventArgs e)
        {
            maximizeLabel.ForeColor = Color.White;
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseLabel_MouseEnter(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.FromArgb(239, 89, 111);
        }

        private void CloseLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.White;
        }
        #endregion
        #region Move form without borders
        private bool mouseDown;
        private Point lastLocation;

        private void FMain_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void FMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point((Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }

        private void FMain_MouseUp(object sender, MouseEventArgs e) => mouseDown = false;
        #endregion
        #region Resize form without borders
        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;

        const int GRIPSIZE = 4;

        new Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, GRIPSIZE); } }
        new Rectangle Left { get { return new Rectangle(0, 0, GRIPSIZE, this.ClientSize.Height); } }
        new Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - GRIPSIZE, this.ClientSize.Width, GRIPSIZE); } }
        new Rectangle Right { get { return new Rectangle(this.ClientSize.Width - GRIPSIZE, 0, GRIPSIZE, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, GRIPSIZE, GRIPSIZE); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - GRIPSIZE, 0, GRIPSIZE, GRIPSIZE); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - GRIPSIZE, GRIPSIZE, GRIPSIZE); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - GRIPSIZE, this.ClientSize.Height - GRIPSIZE, GRIPSIZE, GRIPSIZE); } }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (this.WindowState != FormWindowState.Maximized)
            {
                if (message.Msg == 0x84) // WM_NCHITTEST
                {
                    var cursor = this.PointToClient(Cursor.Position);

                    if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                    else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                    else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                    else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                    else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                    else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                    else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                    else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
                }
            }
        }
        #endregion
        #endregion

        private PageCars CarsPage { get; set; } = new PageCars();
        private PageCustomers CustomersPage { get; set; } = new PageCustomers();
        private PageOffers OffersPage { get; set; } = new PageOffers();
        private PageBookings BookingsPage { get; set; } = new PageBookings();        
        // TODO: Uncomment when features are merged to development branch
        //private PageStatistics StatisticsPage { get; set; } = new PageStatistics();
        //private PageCurrentBookings CurrentBookingsPage { get; set; } = new PageCurrentBookings();
        //private PageBookNew BookNewPage { get; set; } = new PageBookNew();
    }
}
