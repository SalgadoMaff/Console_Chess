using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Chess
{
    internal class PosDict
    {
        public Dictionary<int, int> RowDict { get; private set; } = new Dictionary<int, int>();
        public Dictionary<int, char> ColumnDict { get; private set; } = new Dictionary<int, char>();
        public PosDict()
        {
            RowDict.Add(0, 8);
            RowDict.Add(1, 7);
            RowDict.Add(2, 6);
            RowDict.Add(3, 5);
            RowDict.Add(4, 4);
            RowDict.Add(5, 3);
            RowDict.Add(6, 2);
            RowDict.Add(7, 1);
            ColumnDict.Add(0, 'A');
            ColumnDict.Add(1, 'B');
            ColumnDict.Add(2, 'C');
            ColumnDict.Add(3, 'D');
            ColumnDict.Add(4, 'E');
            ColumnDict.Add(5, 'F');
            ColumnDict.Add(6, 'G');
            ColumnDict.Add(7, 'H');
        }

        public Position toPosition(char column, int row)
        {
            int Column, Row;
            if (column == 'A' || column == 'B' || column == 'C' || column == 'D' || column == 'E' || column == 'F' || column == 'G' || column == 'H')
            {
                Column = ColumnDict.FirstOrDefault(x => x.Value == column).Key;
            }
            else
            {
                throw new BoardException("Invalid input for column!");
            }
            if (row >0 && row<9) {
                Row = RowDict.FirstOrDefault(x => x.Value == row).Key;
            }
            else
            {
                throw new BoardException("Invalid input for row!");
            }
            

            return new Position(Row, Column);
        }
    }
}
