﻿using dn32.infra.atributos;

namespace dn32.infra.dados
{
    [DnDocAtributo]
    public class ResultadoPadrao<T>
    {
        public T Dados { get; set; }

        public ResultadoPadrao()
        {
            Dados = default;
        }

        public ResultadoPadrao(T dados)
        {
            Dados = dados;
        }
    }
}
