using System.ComponentModel.DataAnnotations;

namespace Rapid_Rescue.Model
{
    public class ambulance
    {
        [Key]
        public int ambulancesid { get; set; }

        public string? vehicle_number { get; set; }
        public int equipment_level { get; set; }

        public int current_stastus { get; set; }
    }
}
