using System.Windows.Forms;

namespace SampleLibrary.Infrastructure.Extensions
{
    static class ListViewExtensions
    {
        public static int? GetId(this ListView listView)
        {
            var selectedItem = listView.SelectedItems[0];
            if (selectedItem == null)
                return null;

            return (int) selectedItem.Tag;
        }
    }
}
