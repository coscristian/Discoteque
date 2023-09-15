namespace Discoteque.Data.Models;

public class Tour : BaseEntity<int>
{
    public string TourName {get; set;}
    public string City {get; set;}
    public DateTime Date {get; set;}
    public bool IsSoldOut {get; set;}
    public int ArtistId {get; set;}
}