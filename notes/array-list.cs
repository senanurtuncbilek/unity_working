using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array-list : MonoBehaviour
{
/*
 
    string [] isimler = new string [3];

    isimler[0]="sena";
    isimler[1]="nermin";
    isimler[2]="tar�k";

    Debug.Log(isimler[0]; ---> sena yazar

    YA DA

    string [] isimler = new string[] {"sena","nermin","tar�k"};
    Debug.Log(isimler[0]);


    --dizinin i�indeki eleman say�s� "LENGHT" ifadesiyle bulunur.
      
    Debug.Log("dizinin eleman say�s�: " +isimler.Lenght);


    L�ST

    List<string> isimler = new list <string>();

    isimler.Add("sena");              add--ekle
    isimler.Add("nermin");
    isimler.Add("tar�k");

    Debug.Log(isimler[0]);

    YA DA

    List<string> isimler = new List <string>() {"sena","nermin","tar�k"};
    Debug.Log(isimler[0]);


    --listenin i�indeki eleman say�s� "COUNT" ifadesiyle bulunur.

    Debug.Log("listenin eleman say�s�: " + isimler.Count);

    --listeyi silmek i�in;
    isimler.Clear; --> hespini siler

    isimler.Remove("sena"); -->belirtilen eleman� siler

    isimler.RemoveAt(0);   --> belirtilen numaray� siler

    
   

}
