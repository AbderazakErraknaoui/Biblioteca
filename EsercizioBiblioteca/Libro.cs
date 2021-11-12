using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioBiblioteca
{
    class Libro
    {
        private string _autore;
        private string _titolo;
        private int _dataPubblicazione;
        private string _editore;
        private int _numeroPagine;

        public Libro(string autore, string titolo, int dataPubblicazione, string editore, int numeroPagine)
        {
            Autore = autore;
            Titolo = titolo;
            DataPubblicazione = dataPubblicazione;
            Editore = editore;
            NumeroPagine = numeroPagine;
        }

        public string Autore
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Autore non valido");
                else
                    _autore = value;
            }
            get
            {
                return _autore;
            }
        }

        public string Titolo
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Titolo non valido");
                else
                    _titolo = value;
            }
            get
            {
                return _titolo;
            }
        }

        public int DataPubblicazione
        {
            set
            {
                if (Convert.ToDateTime(value) > DateTime.Today)
                    throw new Exception("DataPubblicazione non valido");
                else
                    _dataPubblicazione = value;
            }
            get
            {
                return _dataPubblicazione;
            }
        }

        public string Editore
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Editore non valido");
                else
                    _editore = value;
            }
            get
            {
                return _editore;
            }
        }

        public int NumeroPagine
        {
            set
            {
                if (value <= 0)
                    throw new Exception("NumeroPagine non valido");
                else
                    _numeroPagine = value;
            }
            get
            {
                return _numeroPagine;
            }
        }

        public int ReadingTime()
        {
            int tempoLettura = 0;

            if (_numeroPagine < 100)
                tempoLettura = 1;
            if (_numeroPagine < 200 || _numeroPagine > 100)
                tempoLettura = 2;
            if (_numeroPagine > 200)
                tempoLettura = 3;

            return tempoLettura;
        }

        public override string ToString()
        {
            return Autore + " " + Titolo + " " + DataPubblicazione + " " + Editore + " " + NumeroPagine;
        }
    }
}
