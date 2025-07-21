using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos
{
    internal class Avaliacao
    {
        public Avaliacao(int nota) 
        {
            if (nota <= 0){

                Nota = 0;

            }else if (nota > 0 && nota <= 10){

               Nota = nota;

            }else{

               Nota = 10;

            }
        }

        public int Nota { get; }

        //Metodo static serve para criar funcoes dentro de um tipo
        public static Avaliacao Parse(string texto)
        {
            int nota = int.Parse(texto); 
            return new Avaliacao(nota);
        }
    }
}
