using Microsoft.EntityFrameworkCore;
using NoteService.Entities;

namespace NoteService.Contexts;

public class NotesDbContext : DbContext
{
    public NotesDbContext(DbContextOptions<NotesDbContext> options) : base(options)
    { }

    public DbSet<Note> Notes { get; set; }
}