
namespace ReportingIssue
{
    partial class XtraReport1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo objectConstructorInfo1 = new DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.chart1 = new DevExpress.XtraReports.UI.XRChart();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.chart1});
            this.Detail.HeightF = 1408.229F;
            this.Detail.Name = "Detail";
            // 
            // chart1
            // 
            this.chart1.BorderColor = System.Drawing.Color.Black;
            this.chart1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xyDiagram1.AxisX.Color = System.Drawing.Color.Black;
            xyDiagram1.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.Sum;
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Hour;
            xyDiagram1.AxisX.DateTimeScaleOptions.ProcessMissingPoints = DevExpress.XtraCharts.ProcessMissingPointsMode.InsertZeroValues;
            xyDiagram1.AxisX.Label.Angle = 270;
            xyDiagram1.AxisX.Label.Font = new System.Drawing.Font("Arial", 9F);
            xyDiagram1.AxisX.Label.TextColor = System.Drawing.Color.Black;
            xyDiagram1.AxisX.NumericScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Automatic;
            xyDiagram1.AxisX.QualitativeScaleOptions.AutoGrid = false;
            xyDiagram1.AxisX.Title.Font = new System.Drawing.Font("Arial", 12F);
            xyDiagram1.AxisX.Title.Text = "Hour";
            xyDiagram1.AxisX.Title.TextColor = System.Drawing.Color.Black;
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Color = System.Drawing.Color.Black;
            xyDiagram1.AxisY.Label.Font = new System.Drawing.Font("Arial", 9F);
            xyDiagram1.AxisY.Label.TextColor = System.Drawing.Color.Black;
            xyDiagram1.AxisY.Title.Font = new System.Drawing.Font("Arial", 12F);
            xyDiagram1.AxisY.Title.Text = "Average Number of Collisions";
            xyDiagram1.AxisY.Title.TextColor = System.Drawing.Color.Black;
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.False;
            this.chart1.Diagram = xyDiagram1;
            this.chart1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chart1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chart1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.RightToLeft;
            this.chart1.Legend.Font = new System.Drawing.Font("Arial", 10F);
            this.chart1.Legend.Name = "Default Legend";
            this.chart1.Legend.TextColor = System.Drawing.Color.Black;
            this.chart1.LocationFloat = new DevExpress.Utils.PointFloat(25F, 33.75F);
            this.chart1.Name = "chart1";
            series1.ArgumentDataMember = "CollisionsByHour.Argument";
            series1.DateTimeSummaryOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Hour;
            series1.DateTimeSummaryOptions.MeasureUnitMultiplier = 1;
            series1.DateTimeSummaryOptions.SummaryFunction = "SUM([CollisionsByHour.Value])";
            series1.FilterString = "[CollisionsByHour.Filter] In (\'Fatal\', \'Injury\') And [CollisionsByHour.Additional" +
    "Info] = False";
            pointSeriesLabel1.BackColor = System.Drawing.Color.White;
            pointSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            pointSeriesLabel1.Font = new System.Drawing.Font("Arial", 8F);
            pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAllAroundPoint;
            pointSeriesLabel1.TextColor = System.Drawing.Color.Black;
            pointSeriesLabel1.TextPattern = "{V:0.#}";
            series1.Label = pointSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.Name = "Fatal & Injury";
            series1.NumericSummaryOptions.SummaryFunction = "COUNT()";
            series1.QualitativeSummaryOptions.SummaryFunction = "SUM([CollisionsByHour.Value])";
            lineSeriesView1.Color = System.Drawing.Color.Navy;
            series1.View = lineSeriesView1;
            series2.ArgumentDataMember = "CollisionsByHour.Argument";
            series2.DateTimeSummaryOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Hour;
            series2.DateTimeSummaryOptions.MeasureUnitMultiplier = 1;
            series2.DateTimeSummaryOptions.SummaryFunction = "SUM([CollisionsByHour.Value])";
            series2.FilterString = "[CollisionsByHour.AdditionalInfo] = False";
            pointSeriesLabel2.BackColor = System.Drawing.Color.White;
            pointSeriesLabel2.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            pointSeriesLabel2.Font = new System.Drawing.Font("Arial", 8F);
            pointSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAllAroundPoint;
            pointSeriesLabel2.TextColor = System.Drawing.Color.Black;
            pointSeriesLabel2.TextPattern = "{V:0.#}";
            series2.Label = pointSeriesLabel2;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series2.Name = "Total";
            series2.NumericSummaryOptions.SummaryFunction = "COUNT()";
            series2.QualitativeSummaryOptions.SummaryFunction = "SUM([CollisionsByHour.Value])";
            lineSeriesView2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            lineSeriesView2.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            lineSeriesView2.LineMarkerOptions.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
            lineSeriesView2.LineMarkerOptions.Size = 5;
            lineSeriesView2.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.View = lineSeriesView2;
            this.chart1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chart1.SizeF = new System.Drawing.SizeF(601.4583F, 422.8125F);
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.Constructor = objectConstructorInfo1;
            this.objectDataSource1.DataSource = typeof(AnnualReport.SafetyAnnualReport);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
            this.DataSource = this.objectDataSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Version = "20.2";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private DevExpress.XtraReports.UI.XRChart chart1;
    }
}
