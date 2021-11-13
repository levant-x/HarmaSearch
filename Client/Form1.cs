using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class HarmaSearch : Form
    {
        const string CSV_PATH = "data_74.csv";

        public HarmaSearch()
        {
            InitializeComponent();
        }

        private void HarmaSearch_Load(object sender, EventArgs e)
        {
            using (var fs = File.OpenText(CSV_PATH))
            {
                ReadStream(fs);
            }
        }

        private void ReadStream(StreamReader sr)
        {
            int c = 0;

            InitColumns(sr.ReadLine());


            while (!sr.EndOfStream && c < 100)
            {
                AddEnterprise(sr.ReadLine());
                //Console.WriteLine(c.ToString() + ") " + sr.ReadLine());
                //lbRawData.Items.Add(sr.ReadLine());
                c++;
            }
        }

        private void InitColumns(string headers)
        {
            var headerParts = headers.Split(',');
            for (int i = 0; i < 100; i++)
            {
                var header = headerParts[i];
                dgvRawData.Columns.Add(header, header);
            }
        }

        private void AddEnterprise(string dataLine)
        {
            var columns = dataLine.Split(',');
            dgvRawData.Rows.Add(columns);
        }
    }
}
