using System.Collections.Generic;

namespace InvoiceApp
{
    public partial class MainAppForm : Form
    {
        public MainAppForm()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            var (content, result) = ReadFile(pathTextBox.Text);
            
            if (!result)
            {
                MessageBox.Show("File does not exist or is not accessible");
                return;
            }

            var prepared = ReplaceSeparator(content);

            Display(prepared);
        }

        private void byCategoryButton_Click(object sender, EventArgs e)
        {
            var (content, result) = ReadFile(pathTextBox.Text);

            if (!result)
            {
                MessageBox.Show("File does not exist or is not accessible");
                return;
            }

            var categories = GroupByCategory(content);

            var grouped = PrepareForDisplay(categories);

            Display(grouped);
        }
        
        private (string[] Content, bool Result) ReadFile(string path)
        {
            try
            {
                return (File.ReadAllLines(path), true);
            }
            catch (Exception)
            {
                return (Array.Empty<string>(), false);
            }
        }

        private string[] ReplaceSeparator(string[] content)
        {
            var result = new List<string>();

            foreach (var line in content) 
                result.Add(line.Replace(";", "\t"));

            return result.ToArray();
        }

        private Dictionary<string, decimal> GroupByCategory(string[] content)
        {
            var dictionary = new Dictionary<string, decimal>();

            for (var i = 1; i < content.Length; i++)
            {
                var line = content[i];

                var split = line.Split(";");

                var category = split[1];
                var amount = Convert.ToDecimal(split[2].Replace(".", ","));

                if (!dictionary.ContainsKey(category))
                    dictionary[category] = amount;
                else
                    dictionary[category] += amount;
            }

            return dictionary;
        }

        private string[] PrepareForDisplay(Dictionary<string, decimal> dictionary)
        {
            var result = new List<string> {$"Category\tAmount"};

            foreach (var entry in dictionary) 
                result.Add($"{entry.Key}\t{entry.Value}");

            return result.ToArray();
        }

        private void Display(string[] content)
        {
            resultTextBox.Clear();

            foreach (var entry in content) 
                resultTextBox.Text += $"{entry}{Environment.NewLine}";
        }
        
        //by month is your homework
    }
}