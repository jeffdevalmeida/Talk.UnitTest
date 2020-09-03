using FluentValidator;
using FluentValidator.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Talk.Domain.Context.ValueObjects
{
    public class EmailVo : Notifiable
    {
        public string Email { get; private set; }
        public EmailVo(string email)
        {
            Email = email;

            AddNotifications(new ValidationContract()
                .Requires()
                .IsEmail(Email, "Email", "O valor informado não corresponde a um endereço de e-mail válido."));
        }
    }
}
