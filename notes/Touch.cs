using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{/*
    MOBÝL PLATFORMLARDA DOKUNMA
       

    Ekrana Dokunma: Touch sýnýfý kullanýlýr
    Nesneye Dokunma: Raycast (ýþýk fiziði) kullanýlýr


    TOUCH SINIFI
    touch: dokunma iþleminin deðiþken türüdür

    "Input.touchCount"-->ekrana dokunan parmak sayýsýný gösterir

    "TouchPhase(TouchPhase.Began,TouchPhase.Moved,TouchPhase.Stationary,TouchPhase.Ended)"--> ekrana dokunan parmaðýn durumunu gösterir

    position: ekrana dokunan parmaðýn x ve y koordinatlarýný verir

    deltaPosition: ekrana dokunan parmaðýn x ve y koordinatýnda kaç piksellik hareket ettiðini gösterir


    NESNEYE DOKUNMA

    RaycastHit nesne:

    Bu deðiþken, ýþýnýn çarptýðý nesnelerin bilgisini verir(ismi,tagý vs)

    "Physics.Raycast(Camera.ScreenPointToRay(x,y,z),outnesne);"  --> kameranýn vector3 türündeki koordinatlarýna ýþýn yollar. Çarptýðý nesnelerin
    bilgisini nesne deðiþkenine atar

    not:mouse a yönelik yapýlan kodlamalarýn hepsi dokunmatik ekrandada çalýþýr




    void OnMouseDown() --> nesneye týklandðýnda bir kez çalýþýr
    void OnMouseUp()  -->nesneye týklayýp parmak çekildiðinde an bir kez çalýþýr
    void OnMouseDrag()  --> nesneye týklayýp parmak sürüklenirken çalýþýr

    MBÝL CÝHAZLARDA ÝVME ÝÞLEMÝ
    

    Input.acceleration.x --> cihazýn yatay eksendeki eðimini verir
    Input.acceleration.y --> cihazýn dikey eksendeki eðimini verir

    SES
    "PlayOneShoot()" fonksiyonunu kullanarak bir kez çalýþacak sesleri çalýþtýrabiliriz


   
}
