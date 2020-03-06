﻿using dn32.infra.nucleo.modelos;
using System;

namespace dn32.infra.nucleo.modelos
{
    internal class DnDescricaoDePropriedade
    {
        public string Nome { get; set; }

        public Type Tipo { get; set; }

        public Type TipoDaPropriedadeDinamica { get; set; }

        public DnDescricaoDaClasse DescricaoDaClasse { get; set; }
    }
}
