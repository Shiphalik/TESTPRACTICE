using System.ComponentModel.DataAnnotations;

namespace TESTPRACTICE.Models
{
    public class LOGREG
    {
        [Key]
         public int UNIQUEID { get; set; }
         public string NUMBER { get; set; }
         public string COUNTRYCODE { get; set; }

    }
}
