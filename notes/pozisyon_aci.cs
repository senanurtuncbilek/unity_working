using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pozisyon_aci : MonoBehaviour
{

    /*  
     
    
              POZÝSYON VE AÇI DEÐÝÞKENLERÝ

    Vector3 degisken;   --> position deðiþkeni x,y,z deðerlerini alýr
    Quaternion degisken2;  -->rotation "         "         "

    gameObject.transform.position= degisken;
    gameObject.transform.rotation= degisken2;

    not: Vector3 deðiþkeninin kendine has bazý " yön kodlarý" var
bu kodlarýn her birinin deðeri 1 birimdir. bunlar;

    ...Translate(1,0,0); yerine ...Translate(Vector3.right);
    ...Translate(-1,0,0); yerine ...Translate(Vector3.left);
    ...Translate(0,1,0); yerine  ...Translate(Vector3.up);
    ...Translate(0,1,0); yerine ...Translate(Vector3.down);





    örn: 
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

