using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstREST.Lib_Primavera.Model
{
    public class Artigo
    {
        public string CodArtigo
        {
            get;
            set;
        }

        public string DescArtigo
        {
            get;
            set;
        }

        public string Observacoes
        {
            get;
            set;
        }

        public string Marca
        {
            get;
            set;
        }

        public string Familia
        {
            get;
            set;
        }

        public string SubFamilia
        {
            get;
            set;
        }

        public double Preco
        {
            get;
            set;
        }

        public double qtdStock // Maybe int?
        {
            get;
            set;
        }

        public string Imagem
        {
            get;
            set;
        }
    }
}