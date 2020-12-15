using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuolaLibrary
{
    public class Studente
    {
        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        public int Matricola { get; set; }

        public Studente(string nome, string cognome, int matricola)
        {
            Nome = nome;
            Cognome = cognome;
            Matricola = matricola;
        }

        public string GetDescrizione()
        {
            return ($"Matr:{Matricola} {Nome} {Cognome}");
        }
    }
}
