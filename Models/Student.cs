using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Student
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(100, MinimumLength = 4, ErrorMessage = "Tên phải có từ 4 đến 100 ký tự")]
    public string? Name { get; set; }
    
    [Required]
    // [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
    [RegularExpression(@"[A-Za-z0-9._%+-]+@gmail.com", 
        ErrorMessage = "Email phải có định dạng @gmail.com")]
    public string? Email { get; set; }
    
    // [StringLength(100, MinimumLength = 8)]
    // [Required]
    [Required]
    [DataType(DataType.Password)]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z\d]).{8,}$",
        ErrorMessage = "Mật khẩu phải từ 8 ký tự trở lên và bao gồm: chữ hoa, chữ thường, chữ số và ký tự đặc biệt")]
    public string? Password { get; set; }
    
    [Required]
    public Branch? Branch { get; set; }
    
    
    [Required]
    public Gender? Gender { get; set; }
    
    [Required]
    [DataType(DataType.Date)]
    [Range(typeof(DateTime), "1/1/1963", "31/12/2005", ErrorMessage = "Ngày sinh không hợp lệ")]
    public DateTime DateOfBirth { get; set; }
    
    [DataType(DataType.MultilineText)]
    [Required]
    public string? Address { get; set; }
   
    [Required]
    public bool IsRegular { get; set; }
    
    [Required]
    [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0")]
    public double Score { get; set; }
}