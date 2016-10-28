using HomeworkControlFlow.Models;
using System;

namespace HomeworkControlFlow.Task2
{
    public class RefactorIfStatements
    {
        public void StatementOne()
        {
            Potato potato = new Potato();

            if (potato != null)
            {
                if (potato.isPeeled() && !potato.isRotten())
                {
                    Cook(potato);
                }
            }
        }

        private void Cook(Potato potato)
        {
            throw new NotImplementedException();
        }

        public void StatementTwo(double x, double y, bool canVisit)
        {
            double minX = 0;
            double minY = 0;
            double maxX = 35;
            double maxY = 20;

            if((x >= minX && x <= maxX) && (y >= minY && y <= maxY) && canVisit)
            {
                VisitCell();
            }
        }

        private void VisitCell() {
            throw new NotImplementedException();
        }
    }
}
