using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpısma : MonoBehaviour
{
   /*

       NESNELERDE ÇARPIŞMA

    --> Çarpışması istenen nesnelerin hepsinde çarpışma componenti olmak zorundadır.Ayrıca en az birinde Rigidbody componentini de olmak zorunda.

    -ihtiyaca göre bir nesneye birkaç tane çarpışma componenti eklenebilir

    Çarpışmalar 2'ye ayrılır
    
    --Sert Çarpışma(COLLİSİON): nesneler çarpıştıklarında birbirine güç uygular  
    --Yumuşak Çarpışma(TRİGGER): çarpıştıklarında birbirlerine güç uygulamazlar, bu sebeple iç içe geçebilirler

    COLLİSİON

    void OnCollisionEnter(Collision çarpılan_nesne){}
    -çarptığında 1 kez çalışır

    void OnCollisionStay(Collision çarpılan_nesne){}
    -çarptığı süresince sürekli çalışır

    void OnCollisionExit(Collision çarpılan_nesne){}
    -çarpma işi bittiğinde 1 kez çalışır

    TRİGGER için;  void OnTriggerEnter(Collider çarpılan_nesne){}
                     "                 "
                     "                 "


   



}
