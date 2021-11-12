using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioBiblioteca
{
    class Biblioteca
    {
        private string _nome;
        private string _indirizzo;
        private DateTime _oraApertura, _oraChiusura;
        private List<Libro> _libri;

        public Biblioteca(string nome, string indirizzo, DateTime oraApertura, DateTime oraChiusura)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            OraApertura = oraApertura;
            OraChiusura = oraChiusura;
            _libri = new List<Libro>();
        }

        public string Nome
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Nome non valido");
                else
                    _nome = value;
            }
            get
            {
                return _nome;
            }
        }

        public string Indirizzo
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Indirizzo non valido");
                else
                    _indirizzo = value;
            }
            get
            {
                return _indirizzo;
            }
        }

        public DateTime OraApertura
        {
            set
            {
                _oraApertura = value;
            }
            get
            {
                return _oraApertura;
            }
        }

        public DateTime OraChiusura
        {
            set
            {
                if (value < _oraApertura)
                    throw new Exception("Ora Chiusura non valida");
                else
                    _oraChiusura = value;
            }
            get
            {
                return _oraChiusura;
            }
        }

        public void AggiuntaLibro(Libro b) //Aggiungo il libro
        {
            _libri.Add(b);
        }

        public List<Libro> GetLista() //Ritorno la Lista
        {
            return _libri;
        }

        public override string ToString()
        {
            return Nome + " " + Indirizzo + " " + OraApertura + " " + OraChiusura;
        }
    }
}
