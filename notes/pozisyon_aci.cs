using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pozisyon_aci : MonoBehaviour
{

    /*  
     
    
              POZ�SYON VE A�I DE���KENLER�

    Vector3 degisken;   --> position de�i�keni x,y,z de�erlerini al�r
    Quaternion degisken2;  -->rotation "         "         "

    gameObject.transform.position= degisken;
    gameObject.transform.rotation= degisken2;

    not: Vector3 de�i�keninin kendine has baz� " y�n kodlar�" var
bu kodlar�n her birinin de�eri 1 birimdir. bunlar;

    ...Translate(1,0,0); yerine ...Translate(Vector3.right);
    ...Translate(-1,0,0); yerine ...Translate(Vector3.left);
    ...Translate(0,1,0); yerine  ...Translate(Vector3.up);
    ...Translate(0,1,0); yerine ...Translate(Vector3.down);





    �rn: 
    public GameObject nesne;

    Vector3 pozisyon;
    Quaternion aci;

    void Start()
    {
    pozisyon= new Vector3(5,0,0);
    aci= Quaternion.Euler(45,0,0);

    gameObject.transform.position= pozisyon;
    gameObject.transform.rotation=aci;
    }
}

