using System;
using System.ComponentModel.DataAnnotations;

public class Booking
{
    [Key]
    public int BookingID { get; set; }

    public int UserID { get; set; }

    public int TourID { get; set; }

    [Required]
    [MaxLength(50)]
    public string Status { get; set; }

    [Required]
    public DateTime BookingDate { get; set; }
}
