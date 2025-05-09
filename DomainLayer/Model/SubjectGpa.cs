using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Model
{
    public class SubjectGpa:BaceEntity
    {
        public string ? SupjectName { get; set; }

        public string ? SubjectPassStatus { get; set; }

        public float GPA {  get; set; }     

        public int  SubjectId { get; set; }

        [ForeignKey("StudentId")]
        public Student ? Students { get; set; }
    }
}
