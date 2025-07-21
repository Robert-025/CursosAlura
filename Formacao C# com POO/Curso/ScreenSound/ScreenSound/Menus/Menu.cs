using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class Menu
    {
        public void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }

        // virtual -> é usada para modificar um método, propriedade, indexador ou evento declarado na classe base e permitir que eles sejam sobrescritos na classe derivada
        public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.Clear();
        }
    }
}
