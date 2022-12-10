using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nesneklonlama : MonoBehaviour
{
   /*
    

    -->Klon oluþturmak için, "Instantiate(prefab,pozisyon,açý)" kodunu kullanýrýz

    -Sonradan kullanabilmek için (sahneye ekleme, çoðaltma gibi) önceden oluþturulmuþ nesne taslaklarýna prefab denir


    GameObject yeni_nesne = Instantiate (nesne,new Vector3(10,10,10),Quaternion.identity);
}
