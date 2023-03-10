using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dotnet6WinFormComponents
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class FlyoutPanel : UserControl
    {
        private bool _IsShow;
        private int _speed = 10;
        private int _winFormBorderWidth = 16;
        private enDockStyle _panelDock = enDockStyle.Top;
        private int _expectedLocation;
        private int _winFormTitleHeight;

        public string Title
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value;
            }
        }

        public Control PanelParentForm
        {
            get
            {
                return this.Parent;
            }
            set
            {
                this.Parent = value;
            }
        }

        public enDockStyle PanelDock
        {
            get
            {
                return _panelDock;
            }
            set
            {
                _panelDock = value;
            }
        }

        public bool ShowClosePanel
        {
            get
            {
                return pnFooter.Visible == true;
            }
            set
            {
                picCloseAtHeader.Visible = value == false;
                pnFooter.Visible = value;
            }
        }

        public Color TitleColor
        {
            get => lblTitle.ForeColor;
            set => lblTitle.ForeColor = value;
        }

        public FlyoutPanel()
        {
            InitializeComponent();
            _IsShow = false;
        }

        public void ShowFlyoutPanel()
        {
            if (!_IsShow)
            {
                InitialUserControl();
                GetExpectedLocation();
                timer1.Start();
            }
        }

        public void HideFlyoutPanel()
        {
            if (_IsShow)
            {
                //InitialUserControl();
                GetExpectedLocation();
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!_IsShow)
            {
                //show the panel

                if (IsExpectedLocation())
                {
                    timer1.Stop();
                    _IsShow = true;
                }
                else
                {
                    ShowPanel(_speed);
                }
            }
            else
            {
                //hide the panel
                if (IsExpectedLocation())
                {
                    timer1.Stop();
                    _IsShow = false;
                }
                else
                {
                    HidePanel(_speed);
                }
            }
        }

        private void FlyoutPanel_Load(object sender, EventArgs e)
        {
            _winFormTitleHeight = GetWinFormTitleHeight();
            if (!DesignMode)
            {
                InitialUserControl();

            }
            this.Invalidate();
        }

        private void GetExpectedLocation()
        {
            switch (_panelDock)
            {
                case enDockStyle.Top:
                    if (!_IsShow)
                    {
                        _expectedLocation = 0;
                    }
                    else
                    {
                        _expectedLocation = -Math.Abs(this.Height);
                    }

                    break;
                case enDockStyle.Bottom:
                    if (!_IsShow)
                    {
                        _expectedLocation = this.ParentForm.Height - this.Height - _winFormTitleHeight;
                    }
                    else
                    {
                        _expectedLocation = (this.ParentForm.Height - _winFormTitleHeight - this.Location.Y) + this.Location.Y;
                    }
                    break;
                case enDockStyle.Left:
                    if (!_IsShow)
                    {
                        _expectedLocation = 0;
                    }
                    else
                    {
                        _expectedLocation = -Math.Abs(this.Width);
                    }

                    break;
                case enDockStyle.Right:
                    if (!_IsShow)
                    {
                        _expectedLocation = this.ParentForm.Width - this.Width;
                    }
                    else
                    {
                        _expectedLocation = (this.ParentForm.Width - this.Location.X) + this.Location.X;
                    }
                    break;
            }
        }

        private void InitialUserControl()
        {
            int X = this.Location.X;
            int Y = this.Location.Y;


            switch (_panelDock)
            {
                case enDockStyle.Top:
                    Y = -Math.Abs(this.Height);
                    this.Width = this.ParentForm.Width - _winFormBorderWidth;
                    break;
                case enDockStyle.Bottom:
                    Y = (this.ParentForm.Height - _winFormTitleHeight - this.Location.Y) + this.Location.Y;
                    this.Width = this.ParentForm.Width - _winFormBorderWidth;
                    break;
                case enDockStyle.Left:
                    X = -Math.Abs(this.Width);
                    this.Height = this.ParentForm.Height;
                    break;
                case enDockStyle.Right:
                    X = (this.ParentForm.Width - this.Location.X) + this.Location.X;
                    this.Height = this.ParentForm.Height;
                    break;
            }
            this.Location = new Point(X, Y);
        }

        private bool IsExpectedLocation()
        {
            bool bRet = false;
            switch (_panelDock)
            {
                case enDockStyle.Top:
                    if (!_IsShow)
                    {
                        if (this.Location.Y >= _expectedLocation)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (this.Location.Y <= _expectedLocation)
                        {
                            return true;
                        }
                    }

                    break;
                case enDockStyle.Bottom:
                    if (!_IsShow)
                    {
                        if (this.Location.Y <= _expectedLocation)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (this.Location.Y >= _expectedLocation)
                        {
                            return true;
                        }
                    }

                    break;
                case enDockStyle.Left:
                    if (!_IsShow)
                    {
                        if (this.Location.X >= _expectedLocation)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (this.Location.X <= _expectedLocation)
                        {
                            return true;
                        }
                    }

                    break;
                case enDockStyle.Right:
                    if (!_IsShow)
                    {
                        if (this.Location.X <= _expectedLocation)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (this.Location.X >= _expectedLocation)
                        {
                            return true;
                        }
                    }

                    break;
            }

            return bRet;
        }

        private void ShowPanel(int speed)
        {
            switch (_panelDock)
            {
                case enDockStyle.Top:
                    this.Location = new Point(0, this.Location.Y + speed);
                    break;
                case enDockStyle.Bottom:
                    this.Location = new Point(0, this.Location.Y - speed);
                    break;
                case enDockStyle.Left:
                    this.Location = new Point(this.Location.X + speed, 0);
                    break;
                case enDockStyle.Right:
                    this.Location = new Point(this.Location.X - speed, 0);
                    break;
            }
            this.Invalidate();
        }

        private void HidePanel(int speed)
        {
            switch (_panelDock)
            {
                case enDockStyle.Top:
                    this.Location = new Point(0, this.Location.Y - speed);
                    break;
                case enDockStyle.Bottom:
                    this.Location = new Point(0, this.Location.Y + speed);
                    break;
                case enDockStyle.Left:
                    this.Location = new Point(this.Location.X - speed, 0);
                    break;
                case enDockStyle.Right:
                    this.Location = new Point(this.Location.X + speed, 0);
                    break;
            }
            this.Invalidate();
        }

        private int GetWinFormTitleHeight()
        {
            return this.ParentForm.Height - this.ParentForm.ClientRectangle.Height;
        }

        private void picCloseAtHeader_Click(object sender, EventArgs e)
        {
            HideFlyoutPanel();
        }
    }

    public enum enDockStyle
    {
        Top,
        Bottom,
        Left,
        Right
    }
}
