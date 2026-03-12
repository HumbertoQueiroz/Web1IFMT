namespace Academico.Models;

public class Professor : Pessoa
{
    public string ciap { get; set; }

    public string area { get; set; }

    public DateOnly dataNascimento{ get; set; }
}
