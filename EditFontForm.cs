namespace CharTable
{
    internal partial class EditCharForm : Form
    {
        private Item? mItem;
        internal EditCharForm(char ch)
        {
            InitializeComponent();

            mItem = ResourceManager.Instance.GetFont(ch);
            if (mItem != null)
            {
                textBox_Char.Text = char.ToString(mItem.Char);
                textBox_Unicode.Text = "0x" + Convert.ToString(mItem.Char, 16).PadLeft(4, '0');
                textBox_Keywords.Text = string.Join(',', mItem.Keywords);
                textBox_UseCount.Text = mItem.UseCount.ToString();
            } 
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (mItem != null)
            {
                string keywords = textBox_Keywords.Text.Trim();
                if(string.Join(',', mItem.Keywords)!= keywords)
                {
                    mItem.SetKeywords(keywords.Split(",").Where(s=>!string.IsNullOrWhiteSpace(s)));
                    ResourceManager.Instance.UpdateFont(mItem);
                }
            }
            Close();
        }
    }
}
