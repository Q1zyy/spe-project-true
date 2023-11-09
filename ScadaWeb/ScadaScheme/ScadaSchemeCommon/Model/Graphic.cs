using Scada.Scheme.Model;
using Scada.Scheme.Model.PropertyGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Xml;
using Scada.Scheme.Model.DataTypes;
using CollectionConverter = Scada.Scheme.Model.PropertyGrid.CollectionConverter;
using CM = System.ComponentModel;


namespace Scada.Scheme.Model
{
    [Serializable]
    public class Chart : BaseComponent, IDynamicComponent
    {
        public event EventHandler DataPointsChanged;

        public static readonly Size DefaultSize = new Size(300, 200);

        [CM.Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public string ChartColor { get; set; }

        [Browsable(false)]
        public Size Size { get; set; }

        [CM.DisplayName("Width")]
        public int Width
        {
            get { return Size.Width; }
            set { Size = new Size(value, Size.Height); }
        }

        [CM.DisplayName("Height")]
        public int Height
        {
            get { return Size.Height; }
            set { Size = new Size(Size.Width, value); }
        }

        [CM.Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public string BackgroundColor { get; set; }

        public string ChartTitle { get; set; }
        public string XAxisTitle { get; set; }
        public string YAxisTitle { get; set; }

        public List<DataPoint> DataPoints { get; set; }
        public Actions Action { get; set; }
        public int InCnlNum { get; set; }
        public int CtrlCnlNum { get; set; }

        public Chart() : base()
        {
            BackgroundColor = "Black";
            ChartColor = "Blue";
            Size = DefaultSize;
            DataPoints = new List<DataPoint>
        {
           new DataPoint { XValue = 10, YValue = 10 },
           new DataPoint { XValue = 40, YValue = 10 },
           new DataPoint { XValue = 40, YValue = 40 },
           new DataPoint { XValue = 10, YValue = 40 },
           new DataPoint { XValue = 10, YValue = 10 },
        };
        }

        public void AddDataPoint(double xValue, double yValue)
        {
            DataPoints.Add(new DataPoint { XValue = xValue, YValue = yValue });
            DataPointsChanged?.Invoke(this, EventArgs.Empty); // вызовите событие
        }

        public void RemoveDataPoint(double xValue, double yValue)
        {
            DataPoints.RemoveAll(p => Math.Abs(p.XValue - xValue) < 1e-10 && Math.Abs(p.YValue - yValue) < 1e-10);
            DataPointsChanged?.Invoke(this, EventArgs.Empty); // вызовите событие
        }

        public void ClearDataPoints()
        {
            DataPoints.Clear();
            DataPointsChanged?.Invoke(this, EventArgs.Empty); // вызовите событие
        }

        public override void LoadFromXml(XmlNode xmlNode)
        {
            base.LoadFromXml(xmlNode);

            ChartColor = xmlNode.GetChildAsString("ChartColor");
            BackgroundColor = xmlNode.GetChildAsString("BackgroundColor");
            ChartTitle = xmlNode.GetChildAsString("ChartTitle");
            XAxisTitle = xmlNode.GetChildAsString("XAxisTitle");
            YAxisTitle = xmlNode.GetChildAsString("YAxisTitle");

            DataPoints.Clear();
            XmlNode dataPointsNode = xmlNode.SelectSingleNode("DataPoints");
            if (dataPointsNode != null)
            {
                foreach (XmlNode dataPointNode in dataPointsNode.SelectNodes("DataPoint"))
                {
                    DataPoint dataPoint = new DataPoint
                    {
                        XValue = dataPointNode.GetChildAsDouble("XValue"),
                        YValue = dataPointNode.GetChildAsDouble("YValue")
                    };
                    DataPoints.Add(dataPoint);
                }
            }
        }

        public override void SaveToXml(XmlElement xmlElem)
        {
            base.SaveToXml(xmlElem);

            xmlElem.AppendElem("ChartColor", ChartColor);
            xmlElem.AppendElem("BackgroundColor", BackgroundColor);
            xmlElem.AppendElem("ChartTitle", ChartTitle);
            xmlElem.AppendElem("XAxisTitle", XAxisTitle);
            xmlElem.AppendElem("YAxisTitle", YAxisTitle);

            XmlElement dataPointsElem = xmlElem.AppendElem("DataPoints");
            foreach (DataPoint dataPoint in DataPoints)
            {
                XmlElement dataPointElem = dataPointsElem.AppendElem("DataPoint");
                dataPointElem.AppendElem("XValue", dataPoint.XValue);
                dataPointElem.AppendElem("YValue", dataPoint.YValue);
            }
        }

        public override BaseComponent Clone()
        {
            Chart clonedComponent = (Chart)base.Clone();
            clonedComponent.DataPoints = new List<DataPoint>(DataPoints.ConvertAll(dataPoint => new DataPoint(dataPoint.XValue, dataPoint.YValue)));
            return clonedComponent;
        }
    }

    [Serializable]
    public class DataPoint
    {
        public double XValue { get; set; }
        public double YValue { get; set; }

        public DataPoint()
        {
            XValue = 0.0;
            YValue = 0.0;
        }

        public DataPoint(double xValue, double yValue)
        {
            XValue = xValue;
            YValue = yValue;
        }

        // ... Дополнительные методы или свойства, если необходимо
    }
}
