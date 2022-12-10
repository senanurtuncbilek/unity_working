using System;
using UnityEngine;

public class Ogretmen : Ogrenci
{
   
    protected void OgrenciveOgretmenAdiniYollar(string ogretmenad, string ogrenciad) //protected erisim turu yalnızca miras alan classlar icin erisim saglar.
    {
        Ogrenciadiver(ogrenciad);
        Debug.Log("Öğretmen adı " + ogretmenad);

    }
}
