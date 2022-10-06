namespace Week6.Models
{
    public class StudentRepository
    {
        private StudentContext context;
        public StudentRepository(StudentContext ctx)
        {
            context = ctx;
        }
        public List<Student> GetAllStudents()
        {
            return context.Students.ToList();
        }
    }
}
