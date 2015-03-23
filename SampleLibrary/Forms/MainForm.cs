using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Data.Repositories;
using SampleLibrary.Infrastructure.Extensions;
using SampleLibrary.Infrastructure.Helpers;

namespace SampleLibrary.Forms
{
    public partial class MainForm : Form
    {
        private readonly CategoryRepository _categoryRepository;
        private readonly UserRepository _userRepository;
        private readonly InterfaceHelper _interfaceHelper;

        public MainForm()
        {
            InitializeComponent();

            _categoryRepository = new CategoryRepository();
            _userRepository = new UserRepository();
            _interfaceHelper = new InterfaceHelper();

            var categories = _categoryRepository.All().Include(x=>x.Books).ToList();
            var users = _userRepository.All().ToList();

            _interfaceHelper.FillTreeViewWithCategories(categoryTreeView, categories);
            _interfaceHelper.FillListViewWithCustomers(usersListView, users);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var addUserForm = new DetailUserForm();
            if (addUserForm.ShowDialog() == DialogResult.OK)
            {
                var users = _userRepository.All().ToList();
                _interfaceHelper.FillListViewWithCustomers(usersListView, users);
            }
        }

        private void редагуватиToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var userId = usersListView.GetId();
            if (userId == null)
                return;

            var form = new DetailUserForm(userId.Value);
            if (form.ShowDialog() == DialogResult.OK)
            {
                var users = _userRepository.All().ToList();
                _interfaceHelper.FillListViewWithCustomers(usersListView, users);
            }
        }

        private void видалитиToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var userId = usersListView.GetId();
            if (userId == null)
                return;

            _userRepository.Delete(userId.Value);
        }
    }
}
