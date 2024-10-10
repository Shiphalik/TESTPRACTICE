using System.ComponentModel.DataAnnotations;

namespace TESTPRACTICE.Models
{
    public class Teachers
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }
        public string ImagePath { get; set; }
        [Required(ErrorMessage = "Please Enter Your Age")]
        public string Age { get; set; }
        [Required(ErrorMessage = "Please Enter Your Gender")]
        public string Sex { get; set; }
        public ICollection<Subjects> Subjects { get; set; }
    }
}
