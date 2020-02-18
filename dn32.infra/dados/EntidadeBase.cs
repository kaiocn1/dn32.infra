﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using dn32.infra.extensoes;

namespace dn32.infra.dados
{
    public abstract class EntidadeBase
    {
        public override bool Equals(object objeto) => GetHashCode() == objeto?.GetHashCode();

        public override int GetHashCode() => ObterIdentificacaoPorPropriedadesChave();

        private int ObterIdentificacaoPorPropriedadesChave()
        {
            var tipo = GetType();
            var json = ObterStringDeValoresChave(tipo);
            return json.GetHashCode();
        }

        private string ObterStringDeValoresChave(Type tipo) => tipo.GetHashCode() + ObterTodosOsValoresDeChaves(tipo).SerializarParaFluenteJson();

        private object[] ObterTodosOsValoresDeChaves(Type tipo)
        {
            var chaves = ObterTodasAsPropriedadesChave(tipo);
            return chaves.Select(x => x.GetValue(this)).ToArray();
        }

        private IEnumerable<PropertyInfo> ObterTodasAsPropriedadesChave(Type tipo) => tipo.GetProperties().Where(x => x.IsDefined(typeof(KeyAttribute)));
    }
}