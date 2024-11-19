namespace SDR_Test.Models
{
    public class Job
    {
        public int ID { get; set; }

        public string JobName { get; set; }

        public string JobDescription { get; set; }

        public int JobStatus { get; set; }

        public DateTime Created
        {
            get; set;
        }

        public DateTime Completed { get; set; }

        public Customers Customer { get; set; }

        public byte[]? Invoice { get; set; }

        public Job()
        {
            Created = DateTime.Now;
        }


    }
}
