using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Component : MonoBehaviour
{
   /*
  
    COMPONENT ER���M�

    "oyunnesnesi.GetComponent<component_ismi>() " koduyla yap�yoruz

    --transform componentinin i�inde "Rotate()" isminde bir fonksiyon tan�mlanm��t�r
    bu fonksiyonu kullanarak nesneleri d�nd�rebiliriz

    �rn:
    void Start()
    {
    de�isken =gameObject.GetComponent<component_ismi>();
    }
    void Update()
    {
    de�isken.Rotate(10,0,0);     --x d�zleminde s�rekli d�ner
    }






    --Transform componentinin i�erisinde "Translate()" isimli bir fonksiyon tan�mlanm��t�r
    bu fonksiyonu kullanarak nesneleri hareket ettirebiliriz.
    (rotate ile ayn� kullan�m)

    --Kodun yaz�ld��� nesnenin kendi componentine eri�iyorsak, "gameObject" kodunu yazmal�y�z.ancak �art de�il
    degisken= gameObject.GetComponent<Transform>() kodunu kullanmaya gerek yoktur. sadece "transform" diyerek de ula�abiliriz.s
}
