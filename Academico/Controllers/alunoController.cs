using Microsoft.AspNetCore.Mvc;
using Academico.Models;

namespace Academico.Controllers;

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        List<Aluno> alunos = new List<Aluno>()
        {
            new Aluno()
            {
                nome = "Humberto",
                cpf = "12345678900",
                matricula = "0000001",
                dataNascimento = new DateOnly(2000, 1, 1)
            },
            new Aluno()
            {
                nome = "Maria",
                cpf = "98765432100",
                matricula = "0000002",
                dataNascimento = new DateOnly(1999, 5, 15)
            }
        };
        return View(alunos);
    }
}