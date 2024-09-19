using System.ComponentModel.DataAnnotations;

namespace Rapid_Rescue.Model
{
    public class Emt
    {
        [Key]
        public int emdId { get; set; }            
        public string? firstName { get; set; }    
        public string? lastName { get; set; }     
        public string? certification { get; set; }  
        public string? phoneNumber { get; set; }     
        public string? email { get; set; }
    }
}
