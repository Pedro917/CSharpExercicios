using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    class Turma
    {
        public List<Aluno> lista = new List<Aluno>();
        private float soma, media, tamanho;

        public void AddAluno(Aluno aluno)
        {
            lista.Add(aluno);
        }

        public float ReturnMedia()
        {

            foreach(var a in lista)
            {
                soma = soma + a.Nota;
                tamanho++;
            }

            media = soma / tamanho;
            return media;
        }


    }
}
