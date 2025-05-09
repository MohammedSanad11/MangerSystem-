using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Model
{
    public class Department:BaceEntity
    {
        public string? DepartmentName { get; set; }

        public int  StudentId  { get; set; }

        [ForeignKey("studintid")]
        public Student ? Students { get; set; }
         
    }
}
