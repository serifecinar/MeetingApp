using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; } // Required olması için null değer kabul etmesi lazım

        [Required]
        public string? Phone { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public bool? WillAttend { get; set; }
    }
}