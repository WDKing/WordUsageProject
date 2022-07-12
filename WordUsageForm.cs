using System.Diagnostics;
using System.Text.RegularExpressions;

namespace WordUsageProject
{
    public partial class WordUsageProjectForm : Form
    {
        string[] linesOfNovel = Array.Empty<string>();

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
                if (!word.Equals("") && word.ToCharArray()[0] != '#')
                {
                    WordToLocate.Items.Add(word);
                }
            }

            linesOfNovel = File.ReadAllLines(@"TextFiles\literature-text.txt");
        }

        private void WordToLocate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string wordToLocate = WordToLocate.SelectedItem.ToString();
            
            Debug.WriteLine($"Word To Locate has changed to: {wordToLocate}");
            System.Diagnostics.Trace.WriteLine($"Trace - Word To Locate has changed to: {wordToLocate}");

            int wordCount = TallyWordCount(wordToLocate);

            FinalCountTextBox.Text = $"The Word \"{wordToLocate}\" was found {wordCount} times.";
        }

        // Private Methods
        private int TallyWordCount(string wordToCount)
        {
            int tally = 0;

            foreach (string line in linesOfNovel) {
                Debug.WriteLine($"Line to split: {line}");
                foreach (var word in Regex.Matches(line, "\\w+('(s|d|t|ve|m|ll))?"))
                {
                    Debug.WriteLine($"Word to find: {wordToCount}, Compare to: {word}");
                    if(wordToCount.ToLower().Equals(word.ToString().ToLower()))
                    {
                        tally++;
                    }
                }
            }

            return tally;
        }
    }
}