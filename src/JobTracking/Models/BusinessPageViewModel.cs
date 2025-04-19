namespace JobTracking.Models
{
    public class BusinessPageViewModel
    {
        public IEnumerable<User>? Users { get; set; }
        public IEnumerable<JobTracking.Models.Task>? Tasks { get; set; }
    }
}