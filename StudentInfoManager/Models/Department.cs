using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StudentInfoManager.Models;

public partial class Department
{
    [Key]
    public int DepartmentId { get; set; }

    [StringLength(100)]
    public string DepartmentName { get; set; } = null!;

    [InverseProperty("Department")]
    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    [InverseProperty("Department")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
