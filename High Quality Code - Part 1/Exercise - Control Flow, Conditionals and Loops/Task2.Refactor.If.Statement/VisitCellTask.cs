using System;

namespace Task2.Refactor.If.Statement
{
    public class VisitCellTask
    {
        private const int MinX = 0;
        private const int MaxX = 100;
        private const int MinY = 0;
        private const int MaxY = 100;

        public void MarkCell(int x, int y)
        {
            bool validateX = MinX <= x && x <= MaxX;
            bool validateY = MinY <= y && y <= MaxY;

            bool cellInRange = validateX && validateY;
            bool shouldVisitCell = CheckCellWhetherToBeVisited(x, y);

            if (cellInRange && shouldVisitCell)
            {
                VisitCell();
            }
        }

        private bool CheckCellWhetherToBeVisited(int x, int y)
        {
            throw new NotImplementedException();
        }

        private void VisitCell()
        {
            // ....
        }
    }
}
