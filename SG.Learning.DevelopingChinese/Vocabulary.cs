using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace SG.Learning.DevelopingChinese
{
    public class Vocabulary
    {
        private readonly List<XElement> _columns;
        private readonly List<Entry> _entries;
        private readonly Header _header;

        public Vocabulary(XElement worksheet)
        {
            var table = worksheet.SpreadsheetElement("Table");
            var numberOfColumns = table.SpreadsheetAttribute("ExpandedColumnCount").AsInteger();
            var numberOfRows = table.SpreadsheetAttribute("ExpandedRowCount").AsInteger();

            _columns = new List<XElement>(numberOfColumns);
            _columns.AddRange(table.SpreadsheetElements("Column"));

            _entries = new List<Entry>(numberOfRows - 1);
            _header = new Header(table.SpreadsheetElement("Row"), numberOfColumns);
            _entries.AddRange(table.SpreadsheetElements("Row").Skip(1).Select(row => new Entry(row, numberOfColumns)));
        }

        public Header ColumnHeader { get { return _header; } }

        public int Count { get { return _entries.Count; } }

        public Entry this[int index]
        {
            get { return _entries[index]; }
        }

        public class Row
        {
            protected readonly XElement Element;
            protected readonly int NumberOfColumns;

            public Row(XElement element, int numberOfColumns)
            {
                Element = element;
                NumberOfColumns = numberOfColumns;
            }

            public string this[int index]
            {
                get
                {
                    XElement cell;
                    return TryFindCell(index, out cell) ? cell.Value : null;
                }
            }

            internal bool TryFindCell(int index, out XElement result)
            {
                var currentIdx = 0;
                result = null;
                foreach (var cell in Element.SpreadsheetElements("Cell"))
                {
                    var indexAttribute = cell.SpreadsheetAttribute("Index");
                    if (indexAttribute != null)
                        currentIdx = indexAttribute.AsInteger();

                    if (currentIdx == index)
                    {
                        result = cell;
                        return true;
                    }

                    currentIdx++;
                }
                return false;
            }

            internal bool TryFindCell(string value, out XElement result, out int index)
            {
                index = 0;
                result = null;
                foreach (var cell in Element.SpreadsheetElements("Cell"))
                {
                    var indexAttribute = cell.SpreadsheetAttribute("Index");
                    if (indexAttribute != null)
                        index = indexAttribute.AsInteger();

                    if (cell.Value == value)
                    {
                        result = cell;
                        return true;
                    }

                    index++;
                }
                return false;
            }
        }

        public class Entry : Row
        {
            public Entry(XElement entry, int numberOfColumns)
                : base(entry, numberOfColumns)
            {
                // calling base
            }
        }

        public class Header : Row
        {
            public Header(XElement header, int numberOfColumns)
                : base(header, numberOfColumns)
            {
                // calling base
            }

            public int this[string columnName]
            {
                get
                {
                    XElement element;
                    int index;
                    return TryFindCell(columnName, out element, out index) ? index : -1;
                }
            }

            public int Count
            {
                get { return NumberOfColumns; }
            }
        }

    }
}