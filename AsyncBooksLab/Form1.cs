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

        // Nadia Cowins
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            // Make sure both books have been selected
            if (!File.Exists(openFileDialog1.FileName) ||
                !File.Exists(openFileDialog2.FileName))
            {
                MessageBox.Show("Please select both books first.");
                return;
            }

            // Clear previous results
            lstReport.Items.Clear();
            lstReport2.Items.Clear();

            btnSubmit.Enabled = false;

            try
            {
                // Start reading both books asynchronously
                Task task1 = ReadBook(openFileDialog1.FileName, lstReport);
                Task task2 = ReadBook(openFileDialog2.FileName, lstReport2);

                //wait until both books are finished
                await Task.WhenAll(task1, task2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading books: " + ex.Message);
            }
            finally
            {
                btnSubmit.Enabled = true;
            }
        }


        // Nadia Cowins
        private async Task ReadBook(string filename, ListBox listBox)
        {
            //read the file asynchronously
            string text = await File.ReadAllTextAsync(filename);

            // count words
            var top10 = await Task.Run(() =>
            {
                
                var words = System.Text.RegularExpressions.Regex
                    .Matches(text.ToLowerInvariant(), @"[a-z]+")
                    .Select(match => match.Value);

                //count each word and find the top 10
                return words
                    .GroupBy(word => word)
                    .Select(group => new
                    {
                        Word = group.Key,
                        Count = group.Count()
                    })
                    .OrderByDescending(item => item.Count)
                    .ThenBy(item => item.Word)
                    .Take(10)
                    .ToList();
            });

            //show results in the correct ListBox
            foreach (var item in top10)
            {
                listBox.Items.Add(item.Word + " - " + item.Count);
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

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFile2.Text = openFileDialog2.FileName.Split("\\").LastOrDefault();
            }
        }

    }
}
