using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StudentInfoManager.Models;

[PrimaryKey("StudentId", "CourseId")]
public partial class StudentCourse
{
    [Key]
    public int StudentId { get; set; }

    [Key]
    public int CourseId { get; set; }

    [StringLength(2)]
    public string? Grade { get; set; }

    [ForeignKey("CourseId")]
    [InverseProperty("StudentCourses")]
    public virtual Course Course { get; set; } = null!;

    [ForeignKey("StudentId")]
    [InverseProperty("StudentCourses")]
    public virtual Student Student { get; set; } = null!;
}
