using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time : MonoBehaviour
{
    /*
         ZAMANA BAÐLI ÝÞLEMLER

    Time.time;
    --oyunun baþlangýcýndan itibaren kaç saniye geçtiði bilgisini verir

    Time.deltaTime;
    --birlikte iþlem yapýldýðý deðere sabit bir zaman aralýðý verir

    Invoke("fonk-ismi",süre);
    --belirlenen süreden sonra istenilen bir fonksiyon 1 kez çalýþtýrýlýr

    InvokeRepeating("fonk_ismi",süre,süre_aralýðý);
    --belirlenen süreden sonra isteniilen bir fonksiyon süre aralýðý boyunca sürekli çalýþýr

    CancelInvoke("fonksiyon_ismi");
    --InvokeRepeating ile çalýþtýrýlan fonksiyonu durdurur



    not: Time.deltaTime kodu sayesinde , cihazýn gücüne göre çalýþan Update fonksiyonunun yarattýðý olumsuzluðu ortadan kaldýrýrýz




}
