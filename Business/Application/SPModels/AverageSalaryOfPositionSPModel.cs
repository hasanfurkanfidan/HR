namespace Application.SPModels
{
    public class AverageSalaryOfPositionSPModel
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public double MinSalary { get; set; }
        public double MaxSalary { get; set; }
        public double AvgSalary { get; set; }
    }
}
