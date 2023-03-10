using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Notificacaoes;

public class Notifica
{
    public Notifica()
    {
        notificacoes = new List<Notifica>();
    }
    [NotMapped]
    public string NomePropiedade { get; set; }
    
    [NotMapped]
    public string mensagem { get; set; }
    
    [NotMapped]
    public List<Notifica> notificacoes;

    public bool ValidarPropiedadeString(string valor, string nomePropiedade)
    {
        if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropiedade))
        {
            notificacoes.Add(new Notifica
            {
                mensagem = "Campo obrigatório",
                NomePropiedade = nomePropiedade
            });
            return false;
        }

        return true;
    }

    public bool ValidarPropiedadeInt(int valor, string nomePropiedade)
    {
        if (valor < 1 || string.IsNullOrWhiteSpace(nomePropiedade))
        {
            notificacoes.Add(new Notifica
            {
                mensagem = "Campo obrigatório",
                NomePropiedade = "nomePropiedade"
            });
            return false;
        }

        return true;
    }
}