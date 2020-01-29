using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class Exercise
    {
        // stwórz algorytm odwracający tablicę
        // przykład:
        // in: 1,2,3 
        // out: 3,2,1
        public int[] ReversArray(int[] array)
        {
            Array.Reverse(array);
            return array;
        }
        // stwórz algorytm zwiękrzający tablicę do podanego rozmiaru bez utraty danych
        //przykład:
        // in: []{1,2,3}, 5
        // out: []{1,2,3,,}
        public int[] Resize(int[] array, int size)
        {

        }
        //stwórz algorytm zwiękrzający lub zmniejszający tablicę do podanego rozmiaru bez utraty danych
        //przykład:
        // in: []{1,2,3}, 2
        // out: []{1,2}
        public int[] ResizeLvlUp(int[] array, int size)
        {

        }
        //stwórz algorytm dopisujący po każdym wystąpieniu znaku podane słowo
        //przykład:
        //in: "ale dziwne zadanie",'e' ,"nie"
        //out: "alenie dziwnenie zadanienie"
        public string CezarCode(string sentence, char character, string word)
        {

        }
        //stwórz algorytm łączący dwie tablice w jedną
        //przykład:
        //in: []{1,2,3}, []{1,2,3}
        //out: []{1,2,3,1,2,3}
        public int[] Join(int[] a, int[] b)
        {

        }
        //stwórz algorytm łączący dwie tablice w jedną ale w taki sposób aby elementy w wyjściu były na przemian (zacznij od tablicy a)
        //przykład:
        //in: []{1,2,3}, []{1,2,3}
        //out: []{1,1,2,2,3,3}
        public int[] HarderJoin(int[] a, int[] b)
        {

        }
        //stwórz algorytm zwracający tablice bool który mówi czy w string-u znajduje się jakaś fraza
        //przykład:
        //in: []{"ale ale","ale tak","ale","a"}, "ale"
        //out: []{true,true,true,false}
        public bool[] Find(string[] senteces, string phrase)
        {
        }
    }
}
