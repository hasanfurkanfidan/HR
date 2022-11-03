namespace Application.Dtos
{
    public class PersonWorkingTimeDto
    {
        public string Person { get; set; }
        public DateTime InDate { get; set; }
        public DateTime OutDate { get; set; }
        public int WorkingTime { get; set; }
    }
}
