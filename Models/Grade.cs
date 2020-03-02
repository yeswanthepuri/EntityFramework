using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityModule.Model
{
    public class Grade
    {
 public int Id { get; set; }
    public string GradeName { get; set; }
    public string Section { get; set; }

    public IList<Student> Students { get; set; }
    }

}