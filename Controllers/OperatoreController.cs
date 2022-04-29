using Microsoft.AspNetCore.Mvc;
using projectwork.Models;
using projectwork.Services;

namespace projectwork.Controllers;

[ApiController]
[Route("operatore")]
public class OperatoreController : ControllerBase
{

    private OperatoreService operatoreService = new OperatoreService();

    [HttpGet]    
    public IEnumerable<Operatore> GetOperatori()
    {
        return operatoreService.GetOperatori();
    }   

    [HttpGet("{id}")]
    public Operatore GetOperatore(int id)
    {
        return operatoreService.GetOperatore(id);
    }

    [HttpPost]
    public IActionResult Create(Operatore operatore)
    {
        var created = operatoreService.Create(operatore);
        if (created)
        {
            return Ok();

        }
        else
        {
            return BadRequest();
        }
    }

    [HttpPut]
    public IActionResult Update(Operatore operatore)
    {
        var updated = operatoreService.Update(operatore);
        if (updated)
        {
            return Ok();

        }
        else
        {
            return BadRequest();
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var deleted = operatoreService.Delete(id);
        if (deleted)
        {
            return Ok();

        }
        else
        {
            return BadRequest();
        }
    }


    
}

