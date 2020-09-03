using System;
using System.Collections.Generic;
using System.Text;
using Talk.Domain.Context.ValueObjects;

namespace Talk.Domain.Context.Entities
{
    public class Cliente : Entity
    {
        public NomeVo Nome { get; private set; }
        public EmailVo Email { get; private set; }

        public Cliente(NomeVo name, EmailVo email)
        {
            Nome = name;
            Email = email;
        }

        public override string ToString()
        {
            return Nome.ToString();
        }
    }
}
