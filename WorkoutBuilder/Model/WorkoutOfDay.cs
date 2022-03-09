using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutBuilder.Model
{
    public class WorkoutOfDay
    {
        [Key]
        public int WorkoutID { get; set; }
        [ForeignKey("WorkoutID")]
        public Workout Workout { get; set; }

        [Required]
        public string Day { get; set; }

        [Range(0, int.MaxValue)]
        public int Sets { get; set; }

        [Range(0, int.MaxValue)]
        public int Reps { get; set; }

        public override string ToString()
        {
            return Workout.ToString() + " " + Sets + "Set(s) " + Reps + "Rep(s)";
        }
    }
}
