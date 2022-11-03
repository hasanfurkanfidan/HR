namespace Application.Dtos
{
    public class AverageSalaryOfPositionDto
    {
        public string Position { get; set; }
        public double MinSalary { get; set; }
        public double MaxSalary { get; set; }
        public double AvgSalary { get; set; }
    }
}
