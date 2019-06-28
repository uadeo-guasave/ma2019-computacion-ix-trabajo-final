using System;

namespace WebApi.Models
{
  public class User
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Role Role { get; set; }
    public UserStatus Status { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public UserGender Gender { get; set; }
    public string RememberToken { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime LastLogin { get; set; }
    public string LastLoginIp { get; set; }
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