using System.ComponentModel.DataAnnotations;

namespace WestcoastEducation.Web.Models;

public class OnDemand
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Content { get; set; } = "";
    public DateTime Start { get; set; } = DateTime.Now;
    public DateTime End { get; set; } = DateTime.Now.AddDays(40);
    public int TeacherId { get; set; }
}