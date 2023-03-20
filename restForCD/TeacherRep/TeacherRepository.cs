using restForCD.Model;
namespace restForCD.TeacherRep
{
    public class TeacherRepository
    {

        private static List<Teacher> data = new List<Teacher>()
        {
            new Teacher(){Id = 1, Name = "John"},
            new Teacher(){Id = 2, Name = "Mikkel"}

        };
        public List<Teacher> GetAll()
        {
            return new List<Teacher>(data);
        }
    }
    
}
