using System.ComponentModel.DataAnnotations;

namespace Rapid_Rescue.Model
{
    public class Users
    {
        [Key]
        public int userId { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? email { get; set; }
        public string? phoneNumber { get; set; }
        public string? password { get; set; }
        public string? date_of_birth { get; set; }
        public string? address { get; set; }
        public int role { get; set; }


    }
}
