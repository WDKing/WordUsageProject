namespace WordUsageProject
{
    public partial class WordUsageProjectForm : Form
    {
        public WordUsageProjectForm()
        {
            InitializeComponent();
        }

        private void WordUsageForm_Load(object sender, EventArgs e)
        {
            
            string[] wordList = File.ReadAllLines(@"TextFiles\stop-word-list.txt");
            foreach (string word in wordList)
            {
                // TODO Add allowance for comments and empty lines
                if (!word.Equals("") && word.ToCharArray()[0] != '#' )
                {
                    WordToLocate.Items.Add(word);
                }
            }
        }

        private void WordToLocate_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Word to search for: WordToLocate.SelectedItem.ToString();
        }

    }
}