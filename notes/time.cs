using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time : MonoBehaviour
{
    /*
         ZAMANA BA�LI ��LEMLER

    Time.time;
    --oyunun ba�lang�c�ndan itibaren ka� saniye ge�ti�i bilgisini verir

    Time.deltaTime;
    --birlikte i�lem yap�ld��� de�ere sabit bir zaman aral��� verir

    Invoke("fonk-ismi",s�re);
    --belirlenen s�reden sonra istenilen bir fonksiyon 1 kez �al��t�r�l�r

    InvokeRepeating("fonk_ismi",s�re,s�re_aral���);
    --belirlenen s�reden sonra isteniilen bir fonksiyon s�re aral��� boyunca s�rekli �al���r

    CancelInvoke("fonksiyon_ismi");
    --InvokeRepeating ile �al��t�r�lan fonksiyonu durdurur



    not: Time.deltaTime kodu sayesinde , cihaz�n g�c�ne g�re �al��an Update fonksiyonunun yaratt��� olumsuzlu�u ortadan kald�r�r�z




}
