namespace AsyncBooksLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            lstReport.Items.Clear();
            List<Task> tasks = new List<Task>();
            var file = openFileDialog1.FileName;
            var wordTask = ReadBook(file, lstReport);
            tasks.Add(wordTask);
            await Task.WhenAll(tasks);
        }

        private async Task ReadBook(string filename, ListBox listBox)
        {
            //implementation for reading the book
            var lines = await File.ReadAllLinesAsync(filename);

            //Process the lines and remove spaces and punctuation
            var arrayLinesCleaned = lines.Where(x => x != string.Empty)
                                        .AsParallel()
                                        .Select(x => x.ToLower()
                                        .Trim()
                                        .Replace(",", "")
                                        .Replace("'", "")
                                        .Replace(".", "")
                                        .Replace("!", ""));
            //Flattening out the array of lines into one array of words
            var arrayOfWords = arrayLinesCleaned.SelectMany(x => x.Split(' '));

            //Create a Dictionary to hold the word counts for each word
            Dictionary<string, int> wordDictionary = new Dictionary<string, int>();

            arrayOfWords.ToList().ForEach(x =>
            {
                if (wordDictionary.ContainsKey(x))
                {
                    wordDictionary[x]++;
                }
                else
                {
                    wordDictionary.Add(x, 1);
                }

            });

            var top10 = wordDictionary.Where(x => !string.IsNullOrWhiteSpace(x.Key))
                                           .OrderByDescending(x => x.Value)
                                           .Take(10);

            foreach (var word in top10)
            {
                listBox.Items.Add(word.Key + " - " + word.Value);
            }


        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName.Split("\\").LastOrDefault();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
