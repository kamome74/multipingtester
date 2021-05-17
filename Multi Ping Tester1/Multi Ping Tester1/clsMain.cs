using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Multi_Ping_Tester
{
    class clsMain
    {
        void WriteWorksheet(WorksheetPart workSheetPart, System.Windows.Forms.ListView.ListViewItemCollection list)
        {
            List<OpenXmlAttribute> attributes;
            OpenXmlWriter writer;

            writer = OpenXmlWriter.Create(workSheetPart);
            writer.WriteStartElement(new Worksheet());
            writer.WriteStartElement(new SheetData());

            int currentRow = 1;

            attributes = new List<OpenXmlAttribute>();
            attributes.Add(new OpenXmlAttribute("r", null, currentRow.ToString()));
            writer.WriteStartElement(new Row(), attributes);



        }
    }
}
