namespace PPB.ViewModels.Cs
{
    public class ComboBoxItem
    {
        public int No { get; set; } = 0;
        public string Text { get; set; } = "";

        public ComboBoxItem(int pNo, string pText)
        {
            No = pNo;
            Text = pText;
        }

    }
}
