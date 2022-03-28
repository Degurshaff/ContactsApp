using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Локальное хранилиже контактов
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Проект для поиска
        /// </summary>
        private List<Contact> _viewedContacts = new List<Contact>();

        /// <summary>
        /// Путь к файлу
        /// </summary>
        private readonly string _filePath = ProjectManager.FilePath();

        /// <summary>
        /// Путь к папке
        /// </summary>
        private readonly string _directoryPath = ProjectManager.DirectoryPath();

        /// <summary>
        /// Загрузка данных
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem_About_Click(object sender, EventArgs e)
        {
            ShowAbout();
        }
       public void ShowAbout()
        {
            //Блокировка формы
            Enabled = false;
            var About = new About();
            using (About)
                About.ShowDialog();
            Enabled = true;
        }

        private void button_AddContact_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            if(listBox_Contacts.SelectedIndex >= 0)
            {
                var selectedContact = _viewedContacts[listBox_Contacts.SelectedIndex];
                UpdateContactList(selectedContact);
            }
            else
            {
                UpdateContactList(null);
            }
        }

        private void UpdateContactList(Contact contact)
        {
        //    _viewedContacts = _project.sor
        }
    }
}
