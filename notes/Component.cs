using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Component : MonoBehaviour
{
   /*
  
    COMPONENT ERÝÞÝMÝ

    "oyunnesnesi.GetComponent<component_ismi>() " koduyla yapýyoruz

    --transform componentinin içinde "Rotate()" isminde bir fonksiyon tanýmlanmýþtýr
    bu fonksiyonu kullanarak nesneleri döndürebiliriz

    örn:
    void Start()
    {
    deðisken =gameObject.GetComponent<component_ismi>();
    }
    void Update()
    {
    deðisken.Rotate(10,0,0);     --x düzleminde sürekli döner
    }






    --Transform componentinin içerisinde "Translate()" isimli bir fonksiyon tanýmlanmýþtýr
    bu fonksiyonu kullanarak nesneleri hareket ettirebiliriz.
    (rotate ile ayný kullaným)

    --Kodun yazýldýðý nesnenin kendi componentine eriþiyorsak, "gameObject" kodunu yazmalýyýz.ancak þart deðil
    degisken= gameObject.GetComponent<Transform>() kodunu kullanmaya gerek yoktur. sadece "transform" diyerek de ulaþabiliriz.s
}
