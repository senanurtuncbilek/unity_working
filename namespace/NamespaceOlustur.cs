using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace olustur1
    // projeler buyudukce artan class say�s�yla, classlar� kullan�mlar�na g�re namespacelere bolebiliriz.
    // ayni isme sahip classlar� namespaceler sayesinde gruplayabiliriz.
   {
 public class sinif1
    {
        public void metot1(int deger)
        {
            Debug.Log("1.1.deger" + deger);
        }


    }


}


namespace olustur2
{
    public class sinif2
    {
        public void metot2(int deger2)
        {
            Debug.Log("2.1.deger" + deger2);
        }
    }
}


