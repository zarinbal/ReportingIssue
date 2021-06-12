
namespace ReportingIssue
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFilterbyReport = new System.Windows.Forms.Button();
            this.btnLinqFatalInjury = new System.Windows.Forms.Button();
            this.btnLinqAdFalse = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Argument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Filter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFilterbyReport
            // 
            this.btnFilterbyReport.Location = new System.Drawing.Point(23, 12);
            this.btnFilterbyReport.Name = "btnFilterbyReport";
            this.btnFilterbyReport.Size = new System.Drawing.Size(509, 161);
            this.btnFilterbyReport.TabIndex = 1;
            this.btnFilterbyReport.Text = " Filter By Report";
            this.btnFilterbyReport.UseVisualStyleBackColor = true;
            this.btnFilterbyReport.Click += new System.EventHandler(this.btnFilterbyReport_Click);
            // 
            // btnLinqFatalInjury
            // 
            this.btnLinqFatalInjury.Location = new System.Drawing.Point(568, 12);
            this.btnLinqFatalInjury.Name = "btnLinqFatalInjury";
            this.btnLinqFatalInjury.Size = new System.Drawing.Size(509, 161);
            this.btnLinqFatalInjury.TabIndex = 1;
            this.btnLinqFatalInjury.Text = "Filter by Linq Additional =False & (Fatal | Injury)";
            this.btnLinqFatalInjury.UseVisualStyleBackColor = true;
            this.btnLinqFatalInjury.Click += new System.EventHandler(this.btnLinqFatalInjury_Click);
            // 
            // btnLinqAdFalse
            // 
            this.btnLinqAdFalse.Location = new System.Drawing.Point(1136, 11);
            this.btnLinqAdFalse.Name = "btnLinqAdFalse";
            this.btnLinqAdFalse.Size = new System.Drawing.Size(509, 161);
            this.btnLinqAdFalse.TabIndex = 1;
            this.btnLinqAdFalse.Text = "Filter by Linq Additional =False";
            this.btnLinqAdFalse.UseVisualStyleBackColor = true;
            this.btnLinqAdFalse.Click += new System.EventHandler(this.btnLinqAdFalse_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(76, 231);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1639, 638);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Argument,
            this.Filter,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Argument
            // 
            this.Argument.Caption = "Argument";
            this.Argument.DisplayFormat.FormatString = "HH:mm";
            this.Argument.FieldName = "Argument";
            this.Argument.MinWidth = 50;
            this.Argument.Name = "Argument";
            this.Argument.Visible = true;
            this.Argument.VisibleIndex = 0;
            this.Argument.Width = 187;
            // 
            // Filter
            // 
            this.Filter.Caption = "Filter";
            this.Filter.FieldName = "Filter";
            this.Filter.MinWidth = 50;
            this.Filter.Name = "Filter";
            this.Filter.Visible = true;
            this.Filter.VisibleIndex = 1;
            this.Filter.Width = 187;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "AdditionalInfo";
            this.gridColumn2.MinWidth = 50;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 187;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Value";
            this.gridColumn3.FieldName = "Value";
            this.gridColumn3.FieldNameSortGroup = "Value";
            this.gridColumn3.MinWidth = 50;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 187;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2032, 962);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnLinqAdFalse);
            this.Controls.Add(this.btnLinqFatalInjury);
            this.Controls.Add(this.btnFilterbyReport);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilterbyReport;
        private System.Windows.Forms.Button btnLinqFatalInjury;
        private System.Windows.Forms.Button btnLinqAdFalse;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Argument;
        private DevExpress.XtraGrid.Columns.GridColumn Filter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}

