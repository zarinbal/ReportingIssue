
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
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel4 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView4 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel5 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView5 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel3 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
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
            this.xrChart1 = new DevExpress.XtraReports.UI.XRChart();
            this.xrChart2 = new DevExpress.XtraReports.UI.XRChart();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart2)).BeginInit();
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
            this.xrChart2,
            this.xrChart1,
            this.chart1});
            this.Detail.HeightF = 1408.229F;
            this.Detail.Name = "Detail";
            // 
            // chart1
            // 
            this.chart1.BorderColor = System.Drawing.Color.Black;
            this.chart1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xyDiagram3.AxisX.Color = System.Drawing.Color.Black;
            xyDiagram3.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.Sum;
            xyDiagram3.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Hour;
            xyDiagram3.AxisX.DateTimeScaleOptions.ProcessMissingPoints = DevExpress.XtraCharts.ProcessMissingPointsMode.InsertZeroValues;
            xyDiagram3.AxisX.Label.Angle = 270;
            xyDiagram3.AxisX.Label.Font = new System.Drawing.Font("Arial", 9F);
            xyDiagram3.AxisX.Label.TextColor = System.Drawing.Color.Black;
            xyDiagram3.AxisX.NumericScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Automatic;
            xyDiagram3.AxisX.QualitativeScaleOptions.AutoGrid = false;
            xyDiagram3.AxisX.Title.Font = new System.Drawing.Font("Arial", 12F);
            xyDiagram3.AxisX.Title.Text = "Hour";
            xyDiagram3.AxisX.Title.TextColor = System.Drawing.Color.Black;
            xyDiagram3.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.Color = System.Drawing.Color.Black;
            xyDiagram3.AxisY.Label.Font = new System.Drawing.Font("Arial", 9F);
            xyDiagram3.AxisY.Label.TextColor = System.Drawing.Color.Black;
            xyDiagram3.AxisY.Title.Font = new System.Drawing.Font("Arial", 12F);
            xyDiagram3.AxisY.Title.Text = "Average Number of Collisions";
            xyDiagram3.AxisY.Title.TextColor = System.Drawing.Color.Black;
            xyDiagram3.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram3.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram3.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram3.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram3.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.False;
            this.chart1.Diagram = xyDiagram3;
            this.chart1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chart1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chart1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.RightToLeft;
            this.chart1.Legend.Font = new System.Drawing.Font("Arial", 10F);
            this.chart1.Legend.Name = "Default Legend";
            this.chart1.Legend.TextColor = System.Drawing.Color.Black;
            this.chart1.LocationFloat = new DevExpress.Utils.PointFloat(25F, 33.75F);
            this.chart1.Name = "chart1";
            series4.ArgumentDataMember = "CollisionsByHour.Argument";
            series4.DateTimeSummaryOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Hour;
            series4.DateTimeSummaryOptions.MeasureUnitMultiplier = 1;
            series4.DateTimeSummaryOptions.SummaryFunction = "SUM([CollisionsByHour.Value])";
            series4.FilterString = "[CollisionsByHour.Filter] In (\'Fatal\', \'Injury\') And [CollisionsByHour.Additional" +
    "Info] = False";
            pointSeriesLabel4.BackColor = System.Drawing.Color.White;
            pointSeriesLabel4.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            pointSeriesLabel4.Font = new System.Drawing.Font("Arial", 8F);
            pointSeriesLabel4.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAllAroundPoint;
            pointSeriesLabel4.TextColor = System.Drawing.Color.Black;
            pointSeriesLabel4.TextPattern = "{V:0.#}";
            series4.Label = pointSeriesLabel4;
            series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series4.Name = "Fatal & Injury";
            series4.NumericSummaryOptions.SummaryFunction = "COUNT()";
            series4.QualitativeSummaryOptions.SummaryFunction = "SUM([CollisionsByHour.Value])";
            lineSeriesView4.Color = System.Drawing.Color.Navy;
            series4.View = lineSeriesView4;
            series5.ArgumentDataMember = "CollisionsByHour.Argument";
            series5.DateTimeSummaryOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Hour;
            series5.DateTimeSummaryOptions.MeasureUnitMultiplier = 1;
            series5.DateTimeSummaryOptions.SummaryFunction = "SUM([CollisionsByHour.Value])";
            series5.FilterString = "[CollisionsByHour.AdditionalInfo] = False";
            pointSeriesLabel5.BackColor = System.Drawing.Color.White;
            pointSeriesLabel5.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            pointSeriesLabel5.Font = new System.Drawing.Font("Arial", 8F);
            pointSeriesLabel5.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAllAroundPoint;
            pointSeriesLabel5.TextColor = System.Drawing.Color.Black;
            pointSeriesLabel5.TextPattern = "{V:0.#}";
            series5.Label = pointSeriesLabel5;
            series5.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series5.Name = "Total";
            series5.NumericSummaryOptions.SummaryFunction = "COUNT()";
            series5.QualitativeSummaryOptions.SummaryFunction = "SUM([CollisionsByHour.Value])";
            lineSeriesView5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            lineSeriesView5.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            lineSeriesView5.LineMarkerOptions.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
            lineSeriesView5.LineMarkerOptions.Size = 5;
            lineSeriesView5.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            series5.View = lineSeriesView5;
            this.chart1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4,
        series5};
            this.chart1.SizeF = new System.Drawing.SizeF(601.4583F, 422.8125F);
            // 
            // xrChart1
            // 
            this.xrChart1.BorderColor = System.Drawing.Color.Black;
            this.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xyDiagram2.AxisX.Color = System.Drawing.Color.Black;
            xyDiagram2.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.Sum;
            xyDiagram2.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Hour;
            xyDiagram2.AxisX.DateTimeScaleOptions.ProcessMissingPoints = DevExpress.XtraCharts.ProcessMissingPointsMode.InsertZeroValues;
            xyDiagram2.AxisX.Label.Angle = 270;
            xyDiagram2.AxisX.Label.Font = new System.Drawing.Font("Arial", 9F);
            xyDiagram2.AxisX.Label.TextColor = System.Drawing.Color.Black;
            xyDiagram2.AxisX.NumericScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Automatic;
            xyDiagram2.AxisX.QualitativeScaleOptions.AutoGrid = false;
            xyDiagram2.AxisX.Title.Font = new System.Drawing.Font("Arial", 12F);
            xyDiagram2.AxisX.Title.Text = "Hour";
            xyDiagram2.AxisX.Title.TextColor = System.Drawing.Color.Black;
            xyDiagram2.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.Color = System.Drawing.Color.Black;
            xyDiagram2.AxisY.Label.Font = new System.Drawing.Font("Arial", 9F);
            xyDiagram2.AxisY.Label.TextColor = System.Drawing.Color.Black;
            xyDiagram2.AxisY.Title.Font = new System.Drawing.Font("Arial", 12F);
            xyDiagram2.AxisY.Title.Text = "Average Number of Collisions";
            xyDiagram2.AxisY.Title.TextColor = System.Drawing.Color.Black;
            xyDiagram2.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram2.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram2.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram2.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram2.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart1.Diagram = xyDiagram2;
            this.xrChart1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.xrChart1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.xrChart1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.RightToLeft;
            this.xrChart1.Legend.Font = new System.Drawing.Font("Arial", 10F);
            this.xrChart1.Legend.Name = "Default Legend";
            this.xrChart1.Legend.TextColor = System.Drawing.Color.Black;
            this.xrChart1.LocationFloat = new DevExpress.Utils.PointFloat(25F, 475.4167F);
            this.xrChart1.Name = "xrChart1";
            series3.ArgumentDataMember = "CollisionsByHour.Argument";
            series3.DateTimeSummaryOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Hour;
            series3.DateTimeSummaryOptions.MeasureUnitMultiplier = 1;
            series3.DateTimeSummaryOptions.SummaryFunction = "SUM([CollisionsByHour.Value])";
            series3.FilterString = "[CollisionsByHour.AdditionalInfo] = False";
            pointSeriesLabel3.BackColor = System.Drawing.Color.White;
            pointSeriesLabel3.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            pointSeriesLabel3.Font = new System.Drawing.Font("Arial", 8F);
            pointSeriesLabel3.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAllAroundPoint;
            pointSeriesLabel3.TextColor = System.Drawing.Color.Black;
            pointSeriesLabel3.TextPattern = "{V:0.#}";
            series3.Label = pointSeriesLabel3;
            series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series3.Name = "Total";
            series3.NumericSummaryOptions.SummaryFunction = "COUNT()";
            series3.QualitativeSummaryOptions.SummaryFunction = "SUM([CollisionsByHour.Value])";
            lineSeriesView3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            lineSeriesView3.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            lineSeriesView3.LineMarkerOptions.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
            lineSeriesView3.LineMarkerOptions.Size = 5;
            lineSeriesView3.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            series3.View = lineSeriesView3;
            this.xrChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.xrChart1.SizeF = new System.Drawing.SizeF(601.4583F, 422.8125F);
            // 
            // xrChart2
            // 
            this.xrChart2.BorderColor = System.Drawing.Color.Black;
            this.xrChart2.Borders = DevExpress.XtraPrinting.BorderSide.None;
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
            this.xrChart2.Diagram = xyDiagram1;
            this.xrChart2.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.xrChart2.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.xrChart2.Legend.Direction = DevExpress.XtraCharts.LegendDirection.RightToLeft;
            this.xrChart2.Legend.Font = new System.Drawing.Font("Arial", 10F);
            this.xrChart2.Legend.Name = "Default Legend";
            this.xrChart2.Legend.TextColor = System.Drawing.Color.Black;
            this.xrChart2.LocationFloat = new DevExpress.Utils.PointFloat(25F, 932.0833F);
            this.xrChart2.Name = "xrChart2";
            series1.ArgumentDataMember = "CollisionsByHour.Argument";
            series1.DateTimeSummaryOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Hour;
            series1.DateTimeSummaryOptions.MeasureUnitMultiplier = 1;
            series1.DateTimeSummaryOptions.SummaryFunction = "SUM([CollisionsByHour.Value])";
            series1.FilterString = "[CollisionsByHour.Filter] In (\'Fatal\', \'Injury\')";
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
            this.xrChart2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.xrChart2.SizeF = new System.Drawing.SizeF(601.4583F, 422.8125F);
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
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private DevExpress.XtraReports.UI.XRChart chart1;
        private DevExpress.XtraReports.UI.XRChart xrChart2;
        private DevExpress.XtraReports.UI.XRChart xrChart1;
    }
}
