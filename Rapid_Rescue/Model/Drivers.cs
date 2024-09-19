using System.ComponentModel.DataAnnotations;

namespace Rapid_Rescue.Model
{
    public class Drivers
    {
        [Key]
        public int driverid { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? phoneNumber { get; set; }
    }
}
