using AmeiRel.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmeiRel.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GeraRelController : ControllerBase
{
    private readonly IWebHostEnvironment _webHostEnvironment;

    public GeraRelController(IWebHostEnvironment webHostEnvironment)
    {
        _webHostEnvironment = webHostEnvironment;
    }
    
    [HttpPost]
    public IActionResult GenerateRelAgendamentos(
        [FromBody] List<Agendamentos> agendamento
        )
    {
        var caminhoReport = Path.Combine(_webHostEnvironment.WebRootPath, @"reports\Agendamento.frx");
        var reportFile = caminhoReport;

        var freport = new FastReport.Report();
        
        freport.Dictionary.RegisterBusinessObject(agendamento, "listaAgendamento", 4, true);
        freport.Report.Save(reportFile);

        return Ok($"Relatório gerado : {caminhoReport}");
    }
}