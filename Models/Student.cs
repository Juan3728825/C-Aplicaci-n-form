namespace FormularioEstudiantes.Formulario.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CareerId { get; set; }
        public Career Career { get; set; }
    }
}
