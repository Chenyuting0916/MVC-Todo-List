using System.ComponentModel.DataAnnotations;

namespace MVC_To_Do_List.Repository.Models;

public class Todo_List
{
    [Key]
    public int Id { get; set; }
    public string Content { get; set; }
    public int Status { get; set; }
}