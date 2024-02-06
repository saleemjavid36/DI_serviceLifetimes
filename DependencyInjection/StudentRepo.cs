namespace DependencyInjection
{
    public class StudentRepo : IStudentRepo
    {
        public string PrintStudentName()
        {
            return "Saleem";
        }
    }
}
