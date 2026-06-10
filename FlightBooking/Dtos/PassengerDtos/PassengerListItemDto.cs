namespace FlightBooking.Dtos.PassengerDtos
{
    public class PassengerListItemDto
    {
        //public string PassengerId { get; set; }

        // Yolcu kolonu
        public string PassengerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        // Cinsiyet
        public string Gender { get; set; }            
        public string PnrNumber { get; set; }            

        // Tip
        public string PassengerType { get; set; }     

        // PNR
        // Koltuk
        public string SeatNumber { get; set; }        

        // Check-in
        public string CheckInStatus { get; set; }     

        // Ödeme
        public string PaymentStatus { get; set; }     

        // Bilet
        public string TicketStatus { get; set; }      

        // İletişim
        public string Phone { get; set; }
    }
}
