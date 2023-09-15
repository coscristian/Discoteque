namespace Discoteque.Data.Models;

public class Song : BaseEntity<int>
{
    public string Name {get; set;} = "";
    public int Length {get; set;}
    public int AlbumId {get; set;} 
}