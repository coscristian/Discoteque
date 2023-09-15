using Discoteque.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Discoteque.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SongController : ControllerBase
{
    [HttpGet]
    [Route("GetAllSongsAsync")]
    public async Task<IActionResult> GetAllSongsAsync()
    {
        List<Song> mySongs = new List<Song>(){
            new Song() {
                Id = 1,
                Name = "Amarte mas no pude",
                Length = 4,
                AlbumId = 1 
            },
            new Song() {
                Id = 2,
                Name = "La plata",
                Length = 3,
                AlbumId = 1 
            },
            new Song() {
                Id = 3,
                Name = "La suerte está echada",
                Length = 5,
                AlbumId = 2 
            }
        };
        return Ok(mySongs);
    }
}