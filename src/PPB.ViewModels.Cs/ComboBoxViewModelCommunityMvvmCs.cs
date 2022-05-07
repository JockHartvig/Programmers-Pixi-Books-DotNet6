using CommunityToolkit.Mvvm.ComponentModel;

using PPB.ViewModels.Cs;

namespace PPB.ViewModels.Cs
{
 
    //----------------------------------------------------------------------
    // ViewModel Class
    //----------------------------------------------------------------------
    [ObservableObject]
    public partial class ComboBoxViewModelCommunityMvvmCs
    {
        [ObservableProperty]
        private List<ComboBoxItem> comboBox1_DataSource = new List<ComboBoxItem>();

        [ObservableProperty]
        private int comboBox1_SelectedValue = 1;

        [ObservableProperty]
        private bool comboBox1_Enabled = false;

        //--------------------------------------------------------------------
        // View Action Methods
        //--------------------------------------------------------------------

        public void Form_Load()
        {

            // Fill DataSource
            comboBox1_DataSource.Add(new ComboBoxItem(0, "Item 0"));
            comboBox1_DataSource.Add(new ComboBoxItem(1, "Item 1"));
            comboBox1_DataSource.Add(new ComboBoxItem(2, "Item 2"));

            // Set ComboBox1 to Enabled
            comboBox1_Enabled = true;
        }

    }
}