using Microsoft.AspNetCore.Mvc.Rendering;

namespace PracticaMVC.Models;


// This is a VIEW MODEL
// This is how different tables or entities can be joined together
public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
}