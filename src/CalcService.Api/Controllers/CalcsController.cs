using CalcService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace CalcService.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalcsController
{
    
    [HttpPost]
    public async Task<Response> Add(int a, int b)
    {
        return new Response
        {
            StatusCode = 200,
            Message = "Success",
            Data = a + b
        };
    }

    [HttpPost]
    public async Task<Response> Separate(int a, int b)
    {
        return new Response
        {
            StatusCode = 200,
            Message = "Success",
            Data = a - b
        };
    }
    
    [HttpPost]
    public async Task<Response> Div(int a, int b)
    {
        return new Response
        {
            StatusCode = 200,
            Message = "Success",
            Data = a / b
        };
    }
    
    [HttpPost]
    public async Task<Response> Multiple(int a, int b)
    {
        return new Response
        {
            StatusCode = 200,
            Message = "Success",
            Data = a * b
        };
    }
}