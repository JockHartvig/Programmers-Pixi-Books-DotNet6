using PPB.ViewModels.Cs;

namespace PPB.WinForms.Cs
{
    public partial class FormComboBoxMvvmCommunityToolkit : Form
    {
        public FormComboBoxMvvmCommunityToolkit()
        {
            InitializeComponent();
        }

        readonly ComboBoxViewModelCommunityMvvmCs formViewModel = new ComboBoxViewModelCommunityMvvmCs();  

        private void FormComboBoxMvvmCommunityToolkit_Load(object sender, EventArgs e)
        {
            formViewModel.Form_Load();

            this.comboBox1.DataBindings.Add("DataSource", formViewModel, "comboBox1_DataSource");
            this.comboBox1.DataBindings.Add("SelectedValue", formViewModel, "comboBox1_SelectedValue");

            this.textBoxSelectedValue.DataBindings.Add("Text", formViewModel, "comboBox1_SelectedValue");


        }

    }
}
