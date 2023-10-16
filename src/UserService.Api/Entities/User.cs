namespace UserService.Api.Entities;

public class User
{
    public long Id { get; set; }
    public string Firstnama { get; set; }
    public string Lastname { get; set; }
    public DateTime DateOfBirth { get; set; }
}