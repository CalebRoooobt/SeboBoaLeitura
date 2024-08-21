using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeboBoaLeitura.DTO
{
    internal class LivroDTO
    {
        private String titulo, autor, editora, categoria, tipo;
        private int ano;
        private double preco;
        private bool capadesgatada, paginasamarelas, grifos, anotacoes, rasgos;

        public LivroDTO(string titulo, string autor, string editora, string categoria, string tipo, int ano, double preco, bool capadesgatada, bool paginasamarelas, bool grifos, bool anotacoes, bool rasgos)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            this.categoria = categoria;
            this.tipo = tipo;
            this.ano = ano;
            this.preco = preco;
            this.capadesgatada = capadesgatada;
            this.paginasamarelas = paginasamarelas;
            this.grifos = grifos;
            this.anotacoes = anotacoes;
            this.rasgos = rasgos;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editora { get => editora; set => editora = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Ano { get => ano; set => ano = value; }
        public double Preco { get => preco; set => preco = value; }
        public bool Capadesgatada { get => capadesgatada; set => capadesgatada = value; }
        public bool Paginasamarelas { get => paginasamarelas; set => paginasamarelas = value; }
        public bool Grifos { get => grifos; set => grifos = value; }
        public bool Anotacoes { get => anotacoes; set => anotacoes = value; }
        public bool Rasgos { get => rasgos; set => rasgos = value; }
    }
}
