using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Model
{
    public class Resules1 : BaceEntity
    {
        public string ? ResultStatus { get; set; }

        public int StudentId { get; set; }
      
        [ForeignKey("studintid")]
        public Student ? Students { get; set; }
    }
}
