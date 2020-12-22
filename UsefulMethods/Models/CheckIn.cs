using System;

namespace UsefulMethods.Models
{
    public class CheckIn
    {
        [CheckInValidation("CheckOutDate", ErrorMessage = "Check in must be before check out date")]
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
