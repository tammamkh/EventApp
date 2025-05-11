using System;
using System.ComponentModel.DataAnnotations;

public class Event
{
    public int Id { get; set; }

    [Required(ErrorMessage = "العنوان مطلوب")]
    [StringLength(100, ErrorMessage = "العنوان لا يمكن أن يتجاوز 100 حرف")]
    public string Title { get; set; }

    [Required(ErrorMessage = "الوصف مطلوب")]
    [StringLength(500, ErrorMessage = "الوصف لا يمكن أن يتجاوز 500 حرف")]
    public string Description { get; set; }

    [Required(ErrorMessage = "التاريخ مطلوب")]
    public DateTime Date { get; set; }

    public int Likes { get; set; }
}
