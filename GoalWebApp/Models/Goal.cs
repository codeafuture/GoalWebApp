using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GoalWebApp.Models
{
    public class Goal
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Target should be a positive number.")]
        public int Target { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Progress should be a positive number.")]
        public int Progress { get; set; }

        [NotMapped]
        public double ProgressPercentage =>  (double)Progress / Target * 100;
    }
}
