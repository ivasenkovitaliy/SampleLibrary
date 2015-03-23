using System;
using System.Windows.Forms;
using Data.Repositories;
using Entities;
using SampleLibrary.Infrastructure.Enums;

namespace SampleLibrary.Forms
{
    public partial class DetailUserForm : Form
    {
        private readonly TypeEvent _typeEvent;
        private readonly UserRepository _userRepository;
        private readonly int _userId;

        public DetailUserForm()
        {
            InitializeComponent();

            _userRepository = new UserRepository();

            _typeEvent = TypeEvent.Create;
        }

        public DetailUserForm(int userId)
        {
            InitializeComponent();
            _typeEvent = TypeEvent.Update;

            _userId = userId;
            _userRepository = new UserRepository();

            var user = _userRepository.Find(userId);
            firstNameTextBox.Text = user.FirstName;
            lastNameTextBox.Text = user.LastName;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (_typeEvent == TypeEvent.Create)
            {
                var user = new User
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text
                };

                _userRepository.Insert(user);
            }
            else if (_typeEvent == TypeEvent.Update)
            {
                var user = _userRepository.Find(_userId);
                user.FirstName = firstNameTextBox.Text;
                user.LastName = lastNameTextBox.Text;

                _userRepository.Update(user);
            }
            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
