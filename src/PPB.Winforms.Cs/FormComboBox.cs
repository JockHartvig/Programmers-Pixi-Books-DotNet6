namespace PPB.WinForms.Cs
{
    public partial class FormComboBox : Form
    {
        public FormComboBox()
        {
            InitializeComponent();
        }

        private void buttonFormComboBoxMvvmCommunityToolkit_Click(object sender, EventArgs e)
        {
            Form form = new FormComboBoxMvvmCommunityToolkit();
            form.ShowDialog();
        }
    }
}
