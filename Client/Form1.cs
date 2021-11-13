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
        public HarmaSearch()
        {
            InitializeComponent();
        }
               
        private void On_bLoadClick(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "*.txt|*.csv";
            dialog.Title = "Choose the file";

            var result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;
            try
            {
                var path = dialog.FileName;
                using (var fs = File.OpenText(path))
                {
                    ReadStream(fs);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Data format invalid or corrupted");
            }
        }

        private void ReadStream(StreamReader sr)
        {
            InitColumns(sr.ReadLine());
            for (int i = 0; i < 100; i++)
            {
                if (sr.EndOfStream) break;
                AddEnterprise(sr.ReadLine());
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
