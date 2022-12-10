using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassVerilerininTumu :  MonoBehaviour /* unity'nin class'ı. Bu sınıfı unity için kullanacagimiz her scripte miras alıyoruz.(unity ile ilgili 
    hazır oluşturulan namespacelerde ki metotlari vs kullanabilmek ve unity ortamına kodları aktarabilmek icin) */
{

    Okul Okul = new Okul(); // new parametresi dahil edilen sinifi olusturup başlatmamizi saglar.
    
    void Start()
    {

        Okul.OgrenciveOgretmenAdiniYollarVeOkulunadi("Kalyon",60,1000f,"Tuğrul","Murat"); /*okul scriptindeki bir metota miras alma yontemi ile eristik. 
       okulda da ögrenci ve ogretmendeki kodlara eriseblimiştik, buradan ogrenci scriptiine erisim saglayabilmemiz OOP de ki KALITIM mantıgıyla oluyor. */
    }

    

    
}
