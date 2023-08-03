using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using System;
using System.Diagnostics;
using ScottPlot;

namespace WetterApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            records = new List<WetterModel>();
        }

        private readonly List<WetterModel> records;

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
                Delimiter = ";",
            };
            using var reader = new StreamReader("210101-220819.csv");
            using var csv = new CsvReader(reader, configuration);
            while (csv.Read())
            {
                try
                {
                    var record = csv.GetRecord<WetterModel>();
                    records.Add(record!);
                }
                catch (CsvHelper.TypeConversion.TypeConverterException)
                {
                }
            }
            checkTemp5.Enabled = true;
            checkTemp30.Enabled = true;
            checkTemp200.Enabled = true;
            checkTemp20.Enabled = true;
            checkFeucht200.Enabled = true;
            checkFeucht30.Enabled = true;
        }

        private void AnyCheckedChanged(object sender, EventArgs e)
        {
            formsPlot1.Plot.Clear();
            DateTime firstDate = records.First().Tag;
            TimeSpan[] dates = records.Select(r => r.Tag.Subtract(firstDate).Add(TimeSpan.FromHours(r.Stunde))).ToArray();
            double[] dataY = dates.Select(x => x.TotalHours).ToArray();

            if (checkTemp20.Checked) formsPlot1.Plot.AddScatter(dataY, records.Select(r => (double)r.B_temp_20).ToArray());
            if (checkTemp200.Checked) formsPlot1.Plot.AddScatter(dataY, records.Select(r => (double)r.L_temp_200).ToArray());
            if (checkTemp30.Checked) formsPlot1.Plot.AddScatter(dataY, records.Select(r => (double)r.L_temp_30).ToArray());
            if (checkTemp5.Checked) formsPlot1.Plot.AddScatter(dataY, records.Select(r => (double)r.B_temp_5).ToArray());
            if (checkFeucht30.Checked) formsPlot1.Plot.AddScatter(dataY, records.Select(r => r.L_feucht_200 ?? 0).ToArray());
            if (checkFeucht200.Checked) formsPlot1.Plot.AddScatter(dataY, records.Select(r => r.L_feucht_30 ?? 0).ToArray());

            formsPlot1.Refresh();
        }
    }
}