using AnnualReport;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TES.Utils;

namespace ReportingIssue
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var repData = GetData();
            var report = new XtraReport1();
            report.DataSource = repData;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        public List<SafetyAnnualReport> GetData()
        {
            var collisionsByHour = JsonTools.ReadJsonFile<List<ReportEntryExtended<DateTime, double, string, bool>>>
                (Path.Combine(Environment.CurrentDirectory, "CollisionsByHour.json"));

            var FatalInjury = collisionsByHour.Where(x =>
            (x.Filter != "Fatal" || x.Filter == "Injury") & x.AdditionalInfo == false).ToList();

            var totalNoAditional = collisionsByHour.Where(x => x.AdditionalInfo == false).ToList();


            return new List<SafetyAnnualReport>
            { new SafetyAnnualReport
            {
                CollisionsByHour =totalNoAditional
            }
        };
        }
    }
}
