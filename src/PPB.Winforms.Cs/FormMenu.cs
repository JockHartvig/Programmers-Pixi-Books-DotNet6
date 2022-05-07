namespace PPB.WinForms.Cs
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonFormComboBox_Click(object sender, EventArgs e)
        {
            Form form = new FormComboBox();
            form.ShowDialog();  
        }
    }
}