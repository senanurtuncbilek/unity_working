using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{/*
    MOB�L PLATFORMLARDA DOKUNMA
       

    Ekrana Dokunma: Touch s�n�f� kullan�l�r
    Nesneye Dokunma: Raycast (���k fizi�i) kullan�l�r


    TOUCH SINIFI
    touch: dokunma i�leminin de�i�ken t�r�d�r

    "Input.touchCount"-->ekrana dokunan parmak say�s�n� g�sterir

    "TouchPhase(TouchPhase.Began,TouchPhase.Moved,TouchPhase.Stationary,TouchPhase.Ended)"--> ekrana dokunan parma��n durumunu g�sterir

    position: ekrana dokunan parma��n x ve y koordinatlar�n� verir

    deltaPosition: ekrana dokunan parma��n x ve y koordinat�nda ka� piksellik hareket etti�ini g�sterir


    NESNEYE DOKUNMA

    RaycastHit nesne:

    Bu de�i�ken, ���n�n �arpt��� nesnelerin bilgisini verir(ismi,tag� vs)

    "Physics.Raycast(Camera.ScreenPointToRay(x,y,z),outnesne);"  --> kameran�n vector3 t�r�ndeki koordinatlar�na ���n yollar. �arpt��� nesnelerin
    bilgisini nesne de�i�kenine atar

    not:mouse a y�nelik yap�lan kodlamalar�n hepsi dokunmatik ekrandada �al���r




    void OnMouseDown() --> nesneye t�kland��nda bir kez �al���r
    void OnMouseUp()  -->nesneye t�klay�p parmak �ekildi�inde an bir kez �al���r
    void OnMouseDrag()  --> nesneye t�klay�p parmak s�r�klenirken �al���r

    MB�L C�HAZLARDA �VME ��LEM�
    

    Input.acceleration.x --> cihaz�n yatay eksendeki e�imini verir
    Input.acceleration.y --> cihaz�n dikey eksendeki e�imini verir

    SES
    "PlayOneShoot()" fonksiyonunu kullanarak bir kez �al��acak sesleri �al��t�rabiliriz


   
}
