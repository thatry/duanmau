using System.ComponentModel.DataAnnotations;

public class Customer
{
    [Key]
    public int CustomerID { get; set; }

    [Required]
    [MaxLength(100)]
    public string Fullname { get; set; }

    [Required]
    [EmailAddress]
    [MaxLength(100)]
    public string Email { get; set; }

    [MaxLength(200)]
    public string Address { get; set; }

    [MaxLength(15)]
    public string PhoneNumber { get; set; }
}
