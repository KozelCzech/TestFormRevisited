using System.Diagnostics;

namespace TestFormRevisited
{
    public partial class TestFormRevised : Form
    {
        private UserModel _model;
        private UserEntity _entity;
        public TestFormRevised()
        {
            InitializeComponent();
            this.Shown += InitMe;
        }


        public void InitMe(object sender, EventArgs e)
        {
            _model = new UserModel();
            _entity = new UserEntity();

            //Console.WriteLine("Boop");

            ControlSetUp();

            LoadInitialListData();
            HideEdit();
            UpdateItems();

            RegisterHandlers();

            //List<Process> processes = new List<Process> ();
            //processes = Process.GetProcesses().ToList();
            //foreach(Process process in processes)
            //{
            //    MessageBox.Show(process.ProcessName);
            //}
        }

        #region Initial Methods
        public void RegisterHandlers()
        {
            this.addButton.Click += (o, e) => AddNewItem();
            this.removeButton.Click += (o, e) => RemoveItem();
            this.saveButton.Click += (o, e) => SaveItem();
            this.cancelButton.Click += (o, e) => CancelItem();
            this.dataGridView1.SelectionChanged += (o, e) => LoadItem();
            this.textBox3.KeyPress += textBox3KeyPress;
        }


        public void ControlSetUp()
        {
            //Form
            this.Text = "TestFormRevised";

            //buttons
            this.addButton.Text = "Add";
            this.removeButton.Text = "Delete";
            this.cancelButton.Text = "Cancel";
            this.saveButton.Text = "Save";

            //labels
            this.label1.Text = "First name:";
            this.label2.Text = "Last name:";
            this.label3.Text = "Age:";

            //datagridview
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = true;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        #endregion


        #region Common Methods
        public void HideEdit()
        {
            if (editPanel.Visible)
            {
                ClearEdit();
                editPanel.Visible = false;
                dataGridView1.Width += editPanel.Width + 5;
            }
            else
                return;
        }


        public void ShowEdit()
        {
            if (_entity != null)
            {
                this.textBox1.Text = _entity.FirstName;
                this.textBox2.Text = _entity.LastName;
                this.textBox3.Text = Convert.ToString(_entity.Age);
            }
            if (!editPanel.Visible)
            {
                editPanel.Visible = true;
                dataGridView1.Width -= editPanel.Width + 5;
            }
            else
                return;
        }


        public void ClearEdit()
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
        }


        public UserEntity TakeData()
        {
            UserEntity user = new UserEntity();
            user.FirstName = this.textBox1.Text;
            user.LastName = this.textBox2.Text;
            user.Age = int.TryParse(textBox3.Text, out int age) ? age : 0;

            return user;
        }


        public void UpdateItems()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _model.Get();
            dataGridView1.ClearSelection();
            dataGridView1.Columns["Id"].Visible = false;
        }
        #endregion


        #region EventHandlers
        public void AddNewItem()
        {
            _entity = null;
            ClearEdit();
            ShowEdit();
        }


        public void RemoveItem()
        {
            if (_entity != null && dataGridView1.SelectedRows.Count > 0)
            {
                _model.Delete(_entity);
                _entity = null;
                UpdateItems();
                HideEdit();
            }
            else
                return;
        }


        public void LoadItem()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                _entity = _model.Get(Guid.Parse(selectedRow.Cells["Id"].Value.ToString()));
                ShowEdit();
            }
            else
                return;
        }


        public void SaveItem()
        {
            if (_entity != null)
            {
                _model.Edit(_entity.Id, TakeData());
            }
            else
            {
                _model.Set(TakeData());
            }
            UpdateItems();
            HideEdit();
        }


        public void CancelItem()
        {
            HideEdit();
        }

        private void textBox3KeyPress(object o, KeyPressEventArgs e)  //Allows only numbers in textBox3
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion


        #region Data methods
        public void LoadInitialListData()
        {
            UserEntity user1 = new UserEntity();
            user1.FirstName = "Bob";
            user1.LastName = "Mathew";
            user1.Age = 57;
            _model.Set(user1);

            UserEntity user2 = new UserEntity();
            user2.FirstName = "Goatley";
            user2.LastName = "The Goat";
            user2.Age = 500;
            _model.Set(user2);
        }
        #endregion
    }
}