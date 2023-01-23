using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace InvoiceManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = textBox1.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("File does not exist. Cannot continue...");
                return;
            }

            var content = File.ReadAllLines(path).Skip(1);

            /////////////////////////////////////////////////////////////////////
            //simple approach (loop based) for 3.0

            //var distinctDates = new List<string>();
            //var totalAmount = 0;
            //foreach (var line in content)
            //{
            //    var split = line.Split("\t");

            //    var date = split[0];
            //    var amount = int.Parse(split[1]);

            //    if (!distinctDates.Contains(date))
            //    {
            //        distinctDates.Add(date);
            //    }

            //    totalAmount += amount;
            //}

            //var outputString = $"Total dates: {distinctDates.Count()}, total amount {totalAmount}.";
            //textBox2.Text = outputString;

            ////////////////////////////////////////////////////////////////////

            //linq approach for 3.0

            //var distinctDatesCount = 
            //    content.Select(x => x.Split("\t")[0]).Distinct().Count();

            //var totalAmount =
            //    content.Sum(x => int.Parse(x.Split("\t")[1]));

            //var outputString = $"Total dates: {distinctDatesCount}, total amount {totalAmount}.";
            //textBox2.Text = outputString;

            /////////////////////////////////////////////////////////////


            //simple approach (loop based) for 4.0

            //            var distinctDates = new List<DateTime>();
            //            var totalAmount = 0;
            //            foreach (var line in content)
            //            {
            //                var split = line.Split("\t");

            //                var date = DateTime.Parse(split[0]);
            //                var amount = int.Parse(split[1]);

            //                if (!distinctDates.Contains(date))
            //                {
            //                    distinctDates.Add(date);
            //                }

            //                totalAmount += amount;
            //            }
            //            var weekDays = new List<string>();
            //            foreach (var date in distinctDates)
            //            {
            //                var dayOfWeek = date.DayOfWeek;
            //                if (!weekDays.Contains(dayOfWeek.ToString()))
            //                {
            //                    weekDays.Add(dayOfWeek.ToString());
            //                }

            //            }

            //            var outputString = @$"Total dates: {distinctDates.Count()}, total amount {totalAmount}.
            //Invoice days: {string.Join(", ", weekDays)}";

            //            textBox2.Text = outputString;

            /////////////////////////////////////////////////////

            //linq approach for 4.0

            //var distinctDatesCount =
            //    content.Select(x => x.Split("\t")[0]).Distinct().Count();

            //var totalAmount =
            //    content.Sum(x => int.Parse(x.Split("\t")[1]));

            //var distinctDaysOfWeek =
            //    content 
            //        .Select(x => DateTime.Parse(x.Split("\t")[0]))
            //        .OrderBy(x => x.DayOfWeek)
            //        .Select(x => x.DayOfWeek.ToString())
            //        .Distinct();

            //var outputString = $"Total dates: {distinctDatesCount}, total amount {totalAmount}.\r\n"
            //    + $"Invoice days: {string.Join(", ", distinctDaysOfWeek)}";
            //textBox2.Text = outputString;
            //////////////////////////////////
            ///


            //simple approach (loop based) for 5.0

            var allDates = new List<DateTime>();
            var totalAmount = 0;
            foreach (var line in content)
            {
                var split = line.Split("\t");

                var date = DateTime.Parse(split[0]);
                var amount = int.Parse(split[1]);

                allDates.Add(date);

                totalAmount += amount;
            }
            var weekDays = new List<string>();
            foreach (var date in allDates)
            {
                var dayOfWeek = date.DayOfWeek;
                if (!weekDays.Contains(dayOfWeek.ToString()))
                {
                    weekDays.Add(dayOfWeek.ToString());
                }
            }

            var monthsPayment = new Dictionary<string, int>();
            foreach (var date in allDates)
            {
                var monthName = ToMonthName(date.Month);

                if (monthsPayment.Keys.Contains(monthName))
                {
                    monthsPayment[monthName] = monthsPayment[monthName] + 1;
                }
                else
                {
                    monthsPayment[monthName] = 1;
                }
            }

            var list = new List<string>();
            foreach (var item in monthsPayment)
            {
                list.Add($"{item.Key} - {item.Value}");
            }


            var outputString = @$"Total dates: {allDates.Distinct().Count()}, total amount {totalAmount}.
Invoice days: {string.Join(", ", weekDays)}
Payments by months: {string.Join(", ", list)}";

            textBox2.Text = outputString;


            //////////////////////
            //Linq approach for 5.0

            //var distinctDatesCount =
            //   content.Select(x => x.Split("\t")[0]).Distinct().Count();

            //var totalAmount =
            //    content.Sum(x => int.Parse(x.Split("\t")[1]));

            //var distinctDaysOfWeek =
            //    content
            //        .Select(x => DateTime.Parse(x.Split("\t")[0]))
            //        .OrderBy(x => x.DayOfWeek)
            //        .Select(x => x.DayOfWeek.ToString())
            //        .Distinct();

            //var byMonth = content
            //    .Select(x => DateTime.Parse(x.Split("\t")[0]))
            //    .GroupBy(x => x.Month)
            //    .Select(x => $"{ToMonthName(x.Key)} - {x.Count()}");

            //var outputString = $"Total dates: {distinctDatesCount}, total amount {totalAmount}.\r\n"
            //    + $"Invoice days: {string.Join(", ", distinctDaysOfWeek)}\r\n"
            //    + $"Payments by months: {string.Join(", ", byMonth)}";
            //textBox2.Text = outputString;
        }

        private static string ToMonthName(int monthNumber)
        {
            switch(monthNumber)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                //and the remaining ones
                default:
                    return "Not recognized number";
            }
        }
    }
}