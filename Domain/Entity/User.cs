using System.ComponentModel.DataAnnotations;

namespace Domain.Entity;

public class User
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Username { get; set; }
    public ICollection<Workspace> Workspaces { get; set; }
    public string RefreshToken { get; set; }
    public string RefreshTokenExpirationTime { get; set; }
}