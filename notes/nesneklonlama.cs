using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nesneklonlama : MonoBehaviour
{
   /*
    

    -->Klon olu�turmak i�in, "Instantiate(prefab,pozisyon,a��)" kodunu kullan�r�z

    -Sonradan kullanabilmek i�in (sahneye ekleme, �o�altma gibi) �nceden olu�turulmu� nesne taslaklar�na prefab denir


    GameObject yeni_nesne = Instantiate (nesne,new Vector3(10,10,10),Quaternion.identity);
}
