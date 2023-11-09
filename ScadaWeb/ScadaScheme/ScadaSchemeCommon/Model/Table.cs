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
    public class Table : BaseComponent, IDynamicComponent
    {
        public static readonly Size DefaultSize = new Size(200, 100);
        public List<List<TableCell>> Rows { get; set; }

        [CM.Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public string HeaderColor { get; set; }

        [CM.Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public List<string> RowColors { get; set; }

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


        public Table() : base()
        {
            HeaderColor = "LightGray";
            RowColors = new List<string> { "LightBlue" };
            Rows = new List<List<TableCell>>();
            Size = DefaultSize;
            Cells = new List<TableCell>(); // инициализация Cells

            // Пример создания таблицы с одним заголовком и одной строкой данных
            List<TableCell> header = new List<TableCell> { new TableCell { Text = "Заголовок", RowIndex = 0, ColIndex = 0 } };
            List<TableCell> row = new List<TableCell> { new TableCell { Text = "Данные", RowIndex = 1, ColIndex = 0 } };

            Rows.Add(header);
            Rows.Add(row);
            Cells.AddRange(header);
            Cells.AddRange(row);
        }


        // Свойства для хранения данных ячеек таблицы
        #region Attributes
        [Scheme.Model.PropertyGrid.DisplayName("Cells"), Scheme.Model.PropertyGrid.Category("Data")]
        [Scheme.Model.PropertyGrid.Description("The data of the table cells.")]

        [TypeConverter(typeof(CollectionConverter))]
        [Editor(typeof(CollectionEditor), typeof(UITypeEditor))]
        #endregion
        public List<TableCell> Cells { get; set; }

        // Методы для работы с XML конфигурацией
        public override void LoadFromXml(XmlNode xmlNode)
        {
            base.LoadFromXml(xmlNode);
            Console.WriteLine("LoadFromXml called.");

            HeaderColor = xmlNode.GetChildAsString("HeaderColor");
            Console.WriteLine($"Loaded HeaderColor: {HeaderColor}");

            RowColors.Clear();
            XmlNode rowsColorNode = xmlNode.SelectSingleNode("RowColors");
            if (rowsColorNode != null)
            {
                foreach (XmlNode colorNode in rowsColorNode.SelectNodes("Color"))
                {
                    RowColors.Add(colorNode.InnerText);
                }
                Console.WriteLine($"Loaded RowColors: {string.Join(", ", RowColors)}");
            }
            else
            {
                Console.WriteLine("No RowColors node found.");
            }

            Cells.Clear();
            XmlNode cellsNode = xmlNode.SelectSingleNode("Cells");
            if (cellsNode != null)
            {
                foreach (XmlNode cellNode in cellsNode.SelectNodes("Cell"))
                {
                    TableCell cell = new TableCell();
                    cell.LoadFromXml(cellNode);
                    Cells.Add(cell);
                }
                Console.WriteLine($"Loaded Cells count: {Cells.Count}");
            }
            else
            {
                Console.WriteLine("No Cells node found.");
            }
        }

        public override void SaveToXml(XmlElement xmlElem)
        {
            base.SaveToXml(xmlElem);

            xmlElem.AppendElem("HeaderColor", HeaderColor);

            XmlElement rowColorsElem = xmlElem.AppendElem("RowColors");
            foreach (string color in RowColors)
            {
                rowColorsElem.AppendElem("Color", color);
            }

            XmlElement cellsElem = xmlElem.AppendElem("Cells");
            foreach (TableCell cell in Cells)
            {
                XmlElement cellElem = cellsElem.AppendElem("Cell");
                cell.SaveToXml(cellElem);
            }
        }

        public override BaseComponent Clone()
        {
            Table clonedComponent = (Table)base.Clone();
            clonedComponent.RowColors = new List<string>(RowColors);
            if (Cells != null)
            {
                clonedComponent.Cells = new List<TableCell>(Cells.ConvertAll(cell => (TableCell)cell.Clone()));
            }
            else
            {
                clonedComponent.Cells = new List<TableCell>();
            }
            return clonedComponent;
        }


        public Actions Action { get; set; }
        public int InCnlNum { get; set; }
        public int CtrlCnlNum { get; set; }
    }

    [Serializable]
    public class TableCell : ICloneable
    {
        public string Text { get; set; }
        public int RowSpan { get; set; }
        public int ColSpan { get; set; }
        public int RowIndex { get; set; }  // новое свойство
        public int ColIndex { get; set; }  // новое свойство

        public TableCell()
        {
            Text = "";
            RowSpan = 1;
            ColSpan = 1;
            RowIndex = 0;  // инициализация нового свойства
            ColIndex = 0;  // инициализация нового свойства
        }

        public void LoadFromXml(XmlNode xmlNode)
        {
            Text = xmlNode.GetChildAsString("Text");
            RowSpan = xmlNode.GetChildAsInt("RowSpan");
            ColSpan = xmlNode.GetChildAsInt("ColSpan");
            RowIndex = xmlNode.GetChildAsInt("RowIndex");  // загрузка нового свойства
            ColIndex = xmlNode.GetChildAsInt("ColIndex");  // загрузка нового свойства
        }

        public void SaveToXml(XmlElement xmlElem)
        {
            xmlElem.AppendElem("Text", Text);
            xmlElem.AppendElem("RowSpan", RowSpan);
            xmlElem.AppendElem("ColSpan", ColSpan);
            xmlElem.AppendElem("RowIndex", RowIndex);  // сохранение нового свойства
            xmlElem.AppendElem("ColIndex", ColIndex);  // сохранение нового свойства
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

}