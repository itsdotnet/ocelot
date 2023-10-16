using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NoteService.Contexts;
using NoteService.Entities;
using NoteService.Models;

namespace NoteService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NotesController : ControllerBase
{
    private NotesDbContext _dbContext;

    public NotesController(NotesDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create(Note note)
    {
        var newNote = await _dbContext.Notes.AddAsync(note);
        await _dbContext.SaveChangesAsync();
        
        return Ok(new Response
        {
            StatusCode = 200,
            Message = "Success",
            Data = newNote.Entity
        });
    }

    [HttpPut("update")]
    public async Task<Response> Update(Note note)
    {
        var existNote = await _dbContext.Notes.FirstOrDefaultAsync(n => note.Id == n.Id);
        if (existNote is null)
            return new Response
            {
                StatusCode = 404,
                Message = "Note not found!",
                Data = null
            };
        existNote.Title = note.Title;
        existNote.Content = note.Content;
        await _dbContext.SaveChangesAsync();
        
        return new Response
        {
            StatusCode = 200,
            Message = "Success",
            Data = existNote
        };
    }

    [HttpDelete("delete")]
    public async Task<Response> Delete(long id)
    {
        var existNote = await _dbContext.Notes.FirstOrDefaultAsync(n => id == n.Id);
        if (existNote is null)
            return new Response
            {
                StatusCode = 404,
                Message = "Note not found!",
                Data = null
            };

        _dbContext.Remove(existNote);
        await _dbContext.SaveChangesAsync();
    
        return new Response
        {
            StatusCode = 200,
            Message = "Success",
            Data = null
        };
    }

    [HttpGet("get")]
    public async Task<Response> Get(long id)
    {
        var existNote = await _dbContext.Notes.FirstOrDefaultAsync(n => id == n.Id);
        if (existNote is null)
            return new Response
            {
                StatusCode = 404,
                Message = "Note not found!",
                Data = null
            };
        
        return new Response
        {
            StatusCode = 200,
            Message = "Success",
            Data = existNote
        };
    }
    
    [HttpGet("getall")]
    public async Task<Response> GetAll()
    {
        var notes = await _dbContext.Notes.ToListAsync();

        return new Response
        {
            StatusCode = 200,
            Message = "Success",
            Data = notes
        };
    }
}