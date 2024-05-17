using Syncfusion.Maui.Data;
using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.GridCommon.ScrollAxis;
using Syncfusion.Maui.Inputs;
using System.Data;
using System.Reflection;
namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        private Group? expandedGroup;

        public MainPage()
        {
            InitializeComponent();            
        }

        private void dataGrid_GroupExpanding(object sender, DataGridColumnGroupChangingEventArgs e)
        {
            var group = e.Group;
            if (expandedGroup == null || group!.Key != expandedGroup.Key)
            {
                foreach (Group otherGroup in dataGrid.View!.Groups)
                {
                    if (group!.Key != otherGroup.Key)
                    {
                        dataGrid.CollapseGroup(otherGroup);
                    }
                }
                expandedGroup = group!;
                dataGrid.ExpandGroup((Group)expandedGroup!);
            }
        }

    }

}
