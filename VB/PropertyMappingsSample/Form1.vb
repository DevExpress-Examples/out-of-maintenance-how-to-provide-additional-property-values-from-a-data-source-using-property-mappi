Imports DevExpress.XtraMap
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace PropertyMappingsSample
    Partial Public Class Form1
        Inherits Form

        Private ReadOnly Property VectorLayer() As VectorItemsLayer
            Get
                Return CType(map.Layers("VectorLayer"), VectorItemsLayer)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#PropertyMappings"
        Private Class StateRect
            ' The latitude of top-left angle of a rectangle.
            Public Property Top() As Double
            ' The longitude of top-left angle of a rectangle.
            Public Property Left() As Double
            ' The width in kilometers of a rectangle.
            Public Property Width() As Double
            ' The height in kilometers of a rectangle.
            Public Property Height() As Double
        End Class

        ' Create a data source.
        Private dataSource As New List(Of StateRect)() From { _
            New StateRect With {.Top = 44.996250, .Left = -111.049638, .Width = 496, .Height = 444}, _
            New StateRect With {.Top = 48.990004, .Left = -104.042967, .Width = 480, .Height = 338}, _
            New StateRect With {.Top = 45.944326, .Left = -104.042967, .Width = 528, .Height = 338}, _
            New StateRect With {.Top = 41.000038, .Left = -109.049518, .Width = 528, .Height = 445} _
        }

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create a data source for the vector layer.
            Dim dataAdapter = New ListSourceDataAdapter()
            dataAdapter.DataSource = dataSource
            dataAdapter.DefaultMapItemType = MapItemType.Rectangle
            ' Specify the obligatory mappings.
            dataAdapter.Mappings.Latitude = "Top"
            dataAdapter.Mappings.Longitude = "Left"
            ' Add rectange specific property mappings.
            dataAdapter.PropertyMappings.AddRange(New MapItemPropertyMappingBase() { _
                New MapRectangleWidthMapping With {.Member = "Width", .DefaultValue = 0}, _
                New MapRectangleHeightMapping With {.Member = "Height", .DefaultValue = 0} _
            })
            VectorLayer.Data = dataAdapter
        End Sub
        #End Region ' #PropertyMappings

    End Class
End Namespace
