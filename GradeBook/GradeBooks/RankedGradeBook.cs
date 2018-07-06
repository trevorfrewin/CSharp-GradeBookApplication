namespace GradeBook.GradeBooks
{
    using Enums;
    
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            base.Type = GradeBookType.Ranked;
        }
    }
}