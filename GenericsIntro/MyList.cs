using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>  //type - tip
    {
        T[] items;
        //constructor
        public MyList()  //ctor tab tab.
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;         //geçici dizinin referans numarasını items tutuyor.Referans numaran new deyince kaybolmayacak artık.
            items = new T[items.Length+1];   //Dizi sayısını bir arttırmalısın.

            for (int   i = 0;  i < tempArray.Length;  i++)
            {
                items[i] = tempArray[i];         //geçici dizidekileri kendi items dizine geri alman gerekiyor.bu yüzden geri istiyorsun!!
                                                 //Kafan yandı tekrarla!!!
            }

            items[items.Length - 1] = item;
        }
    }
}
