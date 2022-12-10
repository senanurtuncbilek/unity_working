using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSource : MonoBehaviour
{
    public AudioSource ses;
    public AudioClip[] sesListe;



    void Start()
    {
        ses = GetComponent<AudioSource>(); //ses degiskenine audio source componentini tanýmla.
    }

    void KosulluOynat()
    {
        string tusAlgila = Input.inputString;   //inputString fonksiyonu: olusturulan arayuzdeki tuslarý klavyeden almak için kullanýlýr.


        switch (tusAlgila)   //klavyeden aldigi degere gore ses oynatacak.
        {
            case "z": ses.clip = sesListe[0];   
                ses.Play();
                break;

            case "x": ses.clip = sesListe[1];
                ses.Play();
                break;
        }



    }
    //sesleri sirayla oynatmak icin:
    public IEnumerator SiraliOynat()  //zamanlý fonksiyon kullanmak icin," .. sn bekle ve islemi gerceklestir"
    {
        int i = 0;
        while (i < sesListe.Length)
        {
            ses.clip = sesListe[i];
            ses.Play;

            yield return new WaitForSeconds(ses.clip.Lenght); //ses dosyasý kadar bekle ve i'yi arttir yani digerine gec
            i++;
        }

        StartCoroutine(SiraliOynat()); //IEnumarator fonksiyonunu calismasi icin bunun icine yazmaliyiz.
        KosulluOynat();
    }

    


    void Update()
    {
        
    }
}
