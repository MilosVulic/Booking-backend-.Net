namespace Booking.Config
{
    public class BookingDatabaseSettings : IBookingDatabaseSettings
    {
        public string UserCollectionName { get; set; }
        public string ReservationCollectionName { get; set; }
        public string AccommodationCollectionName { get; set; }
        public string ApartmentCollectionName { get; set; }
        public string CommentCollectionName { get; set; }
        public string RecensionCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IBookingDatabaseSettings
    {
        string UserCollectionName { get; set; }
        string ReservationCollectionName { get; set; }
        string AccommodationCollectionName { get; set; }
        string ApartmentCollectionName { get; set; }
        string CommentCollectionName { get; set; }
        string RecensionCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}