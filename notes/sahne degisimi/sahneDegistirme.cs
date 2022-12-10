using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahneDegistirme : MonoBehaviour
{
    public void AnaSahne()
    {
        SceneManager.LoadScene("AnaSahne");
    }

    public void Sahne2()
    {
        SceneManager.LoadScene("Sahne2");
    }
    // proje ayarlarýnda "scenes in build"e butun sahneleri ekle

    /* sahneleri hiyerarsi menusune ekliyoruz.
     * hiyerarside daha onceden olusturulan buttonlara componenent olarak "Event Trigger" ekliyoruz, typesýný 
     * "pointer enter(down-exit)" seciyoruz(boylece pointle button uzerine geldigimizde calisir)
     * runtime ve function kýsmýna butonu ve scripts dosyasýný(kullanmak istediðimiz metotu)ekliyoruz.*/
     
}
