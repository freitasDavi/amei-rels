using AmeiRel.Infra;

namespace AmeiRel.Models;

public class Agendamentos : BaseModel
{
    public string NomeAgendamento { get; set; }
    public DateTime DataAgendamento { get; set; }
    public string EnderecoAgendamento { get; set; }
    public string ResponsavelAgendamento { get; set; }
    public string TelefoneAgendamento { get; set; }
    public string TelefoneSecundario { get; set; }
    public User UsuarioAgendamento { get; set; }
}