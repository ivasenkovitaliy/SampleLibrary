using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Entities;

namespace SampleLibrary.Infrastructure.Helpers
{
    class InterfaceHelper
    {
        public void FillTreeViewWithCategories(TreeView treeView, IEnumerable<Category> categories)
        {
            treeView.Nodes.Clear();

            foreach (var category in categories)
            {
                var treeNode = new TreeNode(category.Name) { Tag = category.Id };
                var nodes = category.Books.Select(x => new TreeNode(x.Title) { Tag = x.Id }).ToArray();
                treeNode.Nodes.AddRange(nodes);

                treeView.Nodes.Add(treeNode);
            }
        }

        public void FillListViewWithCustomers(ListView listView, IEnumerable<User> customers)
        {
            listView.Items.Clear();

            var listViewItems = customers.Select(x => new ListViewItem(x.FirstName) { Tag = x.Id }).ToList();

            listViewItems.ForEach(x => listView.Items.Add(x));
        }

        public void FillListViewWithHistory(ListView listView, IEnumerable<History> histories)
        {
            listView.Items.Clear();

            var listViewItems = histories.Select(x => new ListViewItem(x.ToString()) { Tag = x.Id }).ToList();

            listViewItems.ForEach(x => listView.Items.Add(x));
        }
    }
}
