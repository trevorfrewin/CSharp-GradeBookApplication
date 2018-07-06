namespace GradeBook.GradeBooks
{
    using System;
    using System.Linq;
    using Enums;

    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            base.Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (base.Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
            }

            var threshold = (int)Math.Ceiling(base.Students.Count * 0.2);

            var orderedGrades = base.Students.OrderByDescending(s => s.AverageGrade).Select(s => s.AverageGrade).ToList();

            if (orderedGrades[threshold - 1] <= averageGrade)
            {
                return 'A';
            }

            if (orderedGrades[(threshold * 2) - 1] <= averageGrade)
            {
                return 'B';
            }

            if (orderedGrades[(threshold * 3) - 1] <= averageGrade)
            {
                return 'C';
            }

            if (orderedGrades[(threshold * 4) - 1] <= averageGrade)
            {
                return 'D';
            }

            return 'F';
        }
    }
}