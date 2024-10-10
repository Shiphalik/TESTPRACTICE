using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TESTPRACTICE.Models
{
    public class Subjects
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Your Name")]
        [Display(Name ="SUBJECT NAME")]
        public string Name { get; set; }
       
        [Required(ErrorMessage = "Please Enter Your Class")]
        public string Class { get; set; }
        public string Languages { get; set; }
        public int TeacherId { get;set; }
        public Teachers Teachers { get; set; }
    }


}

   
    



