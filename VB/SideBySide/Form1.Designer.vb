Namespace SideBySide
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim secondaryAxisY1 As New DevExpress.XtraCharts.SecondaryAxisY()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (DirectCast(2.12R, Object))})
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (DirectCast(4.75R, Object))})
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (DirectCast(5.65R, Object))})
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (DirectCast(3.87R, Object))})
            Dim series2 As New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesLabel2 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (DirectCast(1000R, Object))})
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (DirectCast(2000R, Object))})
            Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (DirectCast(3000R, Object))})
            Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (DirectCast(4000R, Object))})
            Dim sideBySideBarSeriesView1 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim sideBySideBarSeriesLabel3 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(secondaryAxisY1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            secondaryAxisY1.AxisID = 0
            secondaryAxisY1.Name = "secondaryAxisY1"
            secondaryAxisY1.VisibleInPanesSerializable = "-1"
            xyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() { secondaryAxisY1})
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            series1.Label = sideBySideBarSeriesLabel1
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4})
            sideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            series2.Label = sideBySideBarSeriesLabel2
            series2.Name = "Series 2"
            series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8})
            sideBySideBarSeriesView1.AxisYName = "secondaryAxisY1"
            series2.View = sideBySideBarSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
            sideBySideBarSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel3
            Me.chartControl1.Size = New System.Drawing.Size(426, 271)
            Me.chartControl1.TabIndex = 0
            chartTitle1.Text = "Side-by-Side Series" & ControlChars.CrLf & "Whose Y-Axes are Different"
            chartTitle1.TextColor = System.Drawing.Color.Gray
            Me.chartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(426, 271)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(secondaryAxisY1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(sideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private chartControl1 As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace

