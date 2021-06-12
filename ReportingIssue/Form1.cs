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
        public List<ReportEntryExtended<DateTime, double, string, bool>> HourData { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private static void ShowReport(List<ReportEntryExtended<DateTime, double, string, bool>> collisionsByHour)
        {
            var repData = new List<SafetyAnnualReport>
            { new SafetyAnnualReport
            {
                CollisionsByHour =collisionsByHour
            } };
            var report = new XtraReport1();
            report.DataSource = repData;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HourData = JsonTools.ReadJsonFile<List<ReportEntryExtended<DateTime, double, string, bool>>>
                (Path.Combine(Environment.CurrentDirectory, "CollisionsByHour.json"));
            gridControl1.DataSource = HourData;
            
        }

        private void btnFilterbyReport_Click(object sender, EventArgs e)
        {
            var data = HourData;
            ShowReport(data);
        }

        private void btnLinqFatalInjury_Click(object sender, EventArgs e)
        {
            var data = HourData.Where(x=>x.AdditionalInfo == false && 
            (x.Filter =="Fatal" || x.Filter == "Injury")).ToList();
            ShowReport(data);
        }

        private void btnLinqAdFalse_Click(object sender, EventArgs e)
        {
            var data = HourData.Where(x => x.AdditionalInfo == false).ToList();
            ShowReport(data);
        }
    }
    
}
