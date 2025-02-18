using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LyricsMatch
{
    public partial class StatisticsPage : Form
    {
        public StatisticsPage()
        {
            InitializeComponent();
            FillStatistics();
        }

        private void FillStatistics()
        {
            FillChart(chartGenre,false);
            FillChart(chartLanguage, true);

        }
        private void FillChart(Chart chart, bool isLanguage)
        {
            int maxYValue=0;
            Title title = new Title();
            title.Font = new Font("Sans Serif", 12, FontStyle.Italic);

            Dictionary<string, int> dict = new Dictionary<string, int>();
            if (!isLanguage)
            {
                title.Text = "Lyrics popularity by genre";
                chart.Titles.Add(title);

                foreach (string genreName in DataProvider.Genres)
                    dict.Add(genreName, 0);
                foreach (var item in DataProvider.GetSongViewsByCategory(dict, false))
                {
                    maxYValue= item.Value > maxYValue ? item.Value : maxYValue;
                    chart.Series["Series1"].Points.AddXY(item.Key, item.Value);
                }
            }
            else
            {
                title.Text = "Lyrics popularity by language";
                chart.Titles.Add(title);

                foreach (string langName in DataProvider.Languages)
                    dict.Add(langName, 0);
                foreach (var item in DataProvider.GetSongViewsByCategory(dict, true))
                {
                    maxYValue = item.Value > maxYValue ? item.Value : maxYValue;
                    chart.Series["Series1"].Points.AddXY(item.Key, item.Value);
                }
            }
           
            chart.ChartAreas[0].AxisX.LabelStyle.Angle = 45;
            chart.Series["Series1"].IsXValueIndexed = true;

            chart.ChartAreas["ChartArea1"].AxisX.IsMarginVisible = true;
            chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart.ChartAreas["ChartArea1"].AxisX.Maximum = Double.NaN;
            chart.ChartAreas["ChartArea1"].AxisX.Title = "Genre";
            chart.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Sans Serif", 10, FontStyle.Italic);
         
            chart.ChartAreas["ChartArea1"].AxisY.Interval = maxYValue / (int)10;
            chart.ChartAreas["ChartArea1"].AxisY.Maximum = Double.NaN;
            chart.ChartAreas["ChartArea1"].AxisY.Title = "Total views";
            chart.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Sans Serif", 10, FontStyle.Italic);

        }
    }
}
