namespace GradeBook.GradeBooks
{
    using Enums;
    
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            base.Type = GradeBookType.Standard;
        }
    }
}