﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace ProAgil.Domain
{
    public class Evento
    {
        public int Id { get; private set; }
        public string Local { get; private set; }
        public DateTime? DataEvento { get; private set; }
        public string Tema { get; private set; }
        public int QtdPessoas { get; private set; }
        public string ImagemURL { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public List<Lote> Lotes { get; set; }
        public List<RedeSocial> RedesSociais { get; set; }
        public List<PalestranteEvento> PalestrantesEventos { get; private set; }

    }
}
