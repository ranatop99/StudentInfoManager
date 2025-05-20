using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StudentInfoManager.Models;

public partial class Course
{
    [Key]
    public int CourseId { get; set; }

    [StringLength(100)]
    public string CourseName { get; set; } = null!;

    public int CreditHours { get; set; }

    public int DepartmentId { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("Courses")]
    public virtual Department Department { get; set; } = null!;

    [InverseProperty("Course")]
    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
}
