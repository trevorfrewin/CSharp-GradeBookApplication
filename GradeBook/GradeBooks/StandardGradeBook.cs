namespace GradeBook.GradeBooks
{
    using Enums;
    
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            base.Type = GradeBookType.Standard;
        }
    }
}