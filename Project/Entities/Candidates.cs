namespace Project.Entities
{
    public class Candidates
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime? BeginYear { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public virtual ICollection<Languages> Languages { get; set; } = new List<Languages>();


    }
}
