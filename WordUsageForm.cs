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
            foreach (var word in wordList)
            {
                // TODO Add allowance for comments and empty lines
                wordToLocate.Items.Add(word);
            }
        }

        private void wordToLocate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void finalCountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}