Namespace PropertyMappingsSample
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
            Dim imageTilesLayer1 As New DevExpress.XtraMap.ImageLayer()
            Dim bingMapDataProvider1 As New DevExpress.XtraMap.BingMapDataProvider()
            Dim vectorItemsLayer1 As New DevExpress.XtraMap.VectorItemsLayer()
            Me.map = New DevExpress.XtraMap.MapControl()
            DirectCast(Me.map, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' map
            ' 
            Me.map.CenterPoint = New DevExpress.XtraMap.GeoPoint(42.2R, -106.6R)
            Me.map.Dock = System.Windows.Forms.DockStyle.Fill
            imageTilesLayer1.DataProvider = bingMapDataProvider1
            vectorItemsLayer1.ItemStyle.Fill = System.Drawing.Color.FromArgb((CInt((CByte(128)))), (CInt((CByte(255)))), (CInt((CByte(128)))), (CInt((CByte(0)))))
            vectorItemsLayer1.Name = "VectorLayer"
            Me.map.Layers.Add(imageTilesLayer1)
            Me.map.Layers.Add(vectorItemsLayer1)
            Me.map.Location = New System.Drawing.Point(0, 0)
            Me.map.Name = "map"
            Me.map.Size = New System.Drawing.Size(640, 360)
            Me.map.TabIndex = 0
            Me.map.ZoomLevel = 4R
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(640, 360)
            Me.Controls.Add(Me.map)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.map, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private map As DevExpress.XtraMap.MapControl
    End Class
End Namespace

