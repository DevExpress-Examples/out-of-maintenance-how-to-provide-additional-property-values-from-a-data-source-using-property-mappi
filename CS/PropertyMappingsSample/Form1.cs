using DevExpress.XtraMap;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PropertyMappingsSample {
    public partial class Form1 : Form {
        VectorItemsLayer VectorLayer { get { return (VectorItemsLayer)map.Layers["VectorLayer"]; } }

        public Form1() {
            InitializeComponent();
        }

        #region #PropertyMappings
        class StateRect {
            // The latitude of top-left angle of a rectangle.
            public double Top { get; set; }
            // The longitude of top-left angle of a rectangle.
            public double Left { get; set; }
            // The width in kilometers of a rectangle.
            public double Width { get; set; }
            // The height in kilometers of a rectangle.
            public double Height { get; set; }
        }

        // Create a data source.
        List<StateRect> dataSource = new List<StateRect> {
            new StateRect { Top = 44.996250, Left = -111.049638, Width = 496, Height = 444 },
            new StateRect { Top = 48.990004, Left = -104.042967, Width = 480, Height = 338 },
            new StateRect { Top = 45.944326, Left = -104.042967, Width = 528, Height = 338 },
            new StateRect { Top = 41.000038, Left = -109.049518, Width = 528, Height = 445 }
        };

        private void Form1_Load(object sender, EventArgs e) {
            // Create a data source for the vector layer.
            var dataAdapter = new ListSourceDataAdapter();
            dataAdapter.DataSource = dataSource;
            dataAdapter.DefaultMapItemType = MapItemType.Rectangle;
            // Specify the obligatory mappings.
            dataAdapter.Mappings.Latitude = "Top";
            dataAdapter.Mappings.Longitude = "Left";
            // Add rectange specific property mappings.
            dataAdapter.PropertyMappings.AddRange(new MapItemPropertyMappingBase[] {
                new MapRectangleWidthMapping { Member = "Width", DefaultValue = 0 },
                new MapRectangleHeightMapping { Member = "Height", DefaultValue = 0 }
            });
            VectorLayer.Data = dataAdapter;
        }
        #endregion #PropertyMappings

    }
}
