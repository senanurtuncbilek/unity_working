using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class döngüler : MonoBehaviour
{
 /*
     LOOPS

  while(koşul)
  {
  kodlar
  }

    örn:
    while(rakam<100)
    {
    Debug.Log("rakam:" +rakam);
    rakam++;
    }


   for(başlangıçdeğeri;koşul;artma-azalma)
   {
   kodlar
   }

    örn: 
    for(int rakam=1;rakam<100;rakam++)
    {
        Debug.Log("rakam: "+rakam);    
    }



    foreach(değişken in liste-dizi)
    {
         kodlar    
    }

    örn:
    int [] rakamlar = new int [] {0,1,2,3,4,5,6,7,8,9}
    foreach(int rakam in rakamlar){
    Debug.Log("rakam: "+rakam);
    }


}
