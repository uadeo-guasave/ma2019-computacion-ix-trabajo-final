using System;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace WebApi.Models
{
  public class User
  {
    public int Id { get; set; }
    [Required, MaxLength(20)]
    public string Name { get; set; }
    [Required, MaxLength(300)]
    public string Password { get; set; }
    [Required, MaxLength(50)]
    public string FirstName { get; set; }
    [Required, MaxLength(50)]
    public string LastName { get; set; }
    [Required]
    public int RoleId { get; set; }
    public Role Role { get; set; }
    [Required]
    public UserStatus Status { get; set; }
    [Required, MaxLength(200)]
    public string Email { get; set; }
    [MaxLength(30)]
    public string Phone { get; set; }
    [Required]
    public UserGender Gender { get; set; }
    [MaxLength(300)]
    public string RememberToken { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
    [Required]
    public DateTime UpdatedAt { get; set; }
    [Required]
    public DateTime LastLogin { get; set; }
    [Required]
    public IPAddress LastLoginIp { get; set; }
  }
  public enum UserStatus
  {
    Activated = 1,
    Deactivated = 0
  }

  public enum UserGender
  {
    Masculino,
    Femenino
  }
}