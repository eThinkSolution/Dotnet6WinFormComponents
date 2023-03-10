using System.ComponentModel;
using System.ComponentModel.Design;

namespace Dotnet6WinFormComponents
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class ControlContainer : UserControl
    {
        public ControlContainer()
        {
            InitializeComponent();
        }
    }
}