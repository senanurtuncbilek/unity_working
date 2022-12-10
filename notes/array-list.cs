using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array-list : MonoBehaviour
{
/*
 
    string [] isimler = new string [3];

    isimler[0]="sena";
    isimler[1]="nermin";
    isimler[2]="tarýk";

    Debug.Log(isimler[0]; ---> sena yazar

    YA DA

    string [] isimler = new string[] {"sena","nermin","tarýk"};
    Debug.Log(isimler[0]);


    --dizinin içindeki eleman sayýsý "LENGHT" ifadesiyle bulunur.
      
    Debug.Log("dizinin eleman sayýsý: " +isimler.Lenght);


    LÝST

    List<string> isimler = new list <string>();

    isimler.Add("sena");              add--ekle
    isimler.Add("nermin");
    isimler.Add("tarýk");

    Debug.Log(isimler[0]);

    YA DA

    List<string> isimler = new List <string>() {"sena","nermin","tarýk"};
    Debug.Log(isimler[0]);


    --listenin içindeki eleman sayýsý "COUNT" ifadesiyle bulunur.

    Debug.Log("listenin eleman sayýsý: " + isimler.Count);

    --listeyi silmek için;
    isimler.Clear; --> hespini siler

    isimler.Remove("sena"); -->belirtilen elemaný siler

    isimler.RemoveAt(0);   --> belirtilen numarayý siler

    
   

}
