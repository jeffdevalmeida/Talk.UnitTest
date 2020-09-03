using FluentValidator;
using FluentValidator.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Talk.Domain.Context.ValueObjects
{
    public class NomeVo : Notifiable
    {
        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }

        public NomeVo(string primeiroNome, string ultimoNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;

            AddNotifications(new ValidationContract()
                .Requires()
                .HasMinLen(PrimeiroNome, 3, "PrimeiroNome", "O primeiro nome do usuário deve conter pelo menos 3 caracteres.")
                .HasMaxLen(PrimeiroNome, 20, "PrimeiroNome", "O primeiro nome do usuário deve conter no máximo 20 caracteres.")

                .HasMinLen(UltimoNome, 3, "UltimoNome", "O último nome do usuário deve conter pelo menos 3 caracteres.")
                .HasMaxLen(UltimoNome, 20, "UltimoNome", "O último nome do usuário deve conter no máximo 20 caracteres."));
        }

        public override string ToString()
        {
            return $"{PrimeiroNome} {UltimoNome}";
        }
    }
}
