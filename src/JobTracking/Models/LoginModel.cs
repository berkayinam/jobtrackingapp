using Microsoft.AspNetCore.Mvc;

namespace JobTracking.Models
{
    public class LoginModel
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}