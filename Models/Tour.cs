using System;
using System.ComponentModel.DataAnnotations;

public class Tour
{
    [Key]
    public int TourID { get; set; }

    [Required]
    [MaxLength(100)]
    public string TourName { get; set; }

    public string Description { get; set; }

    [Required]
    public DateTime StartDate { get; set; }

    [Required]
    public DateTime EndDate { get; set; }

    [Required]
    [Range(0, 9999999999.99)]
    public decimal Price { get; set; }
}
