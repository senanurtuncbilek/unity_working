using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caroutine_fonksiyonu : MonoBehaviour
{/*
    CAROUT�NE

    1-Bir fonksiyonu, belli bir saniye sonra 1 kez �al��t�rabiliriz(Invoke() gibi)

    2-Bir fonksiyonu,belli saniyeler aral���nda s�rekli �al��t�rabilir(InvokeRepeating() gibi)

    3-Belli bir saniye sonra 1 kez veya belli bir saniye aral���nda s�rekli �al��an "de�er alabilen" bir fonksiyonu �al��t�rabilir
    4-�nternetten,bir klas�rden,veri taban�ndan veya dosyadan veri �ekmek gibi bir i� yaparken, i�in bitmesini bekleyebilir.ilgili fonksiyonun �al��mas�n� 
    ona g�re d�zenleyebilir


    not: caroutine fonksiyonlar� ;
    1- fonksiyonlar� tan�mlan�rken, IEnumarator t�r�nden de�er d�nd�rd�klerinden, isimlerinde mutlaka IEnumarator ifadesi olmak zorundad�r
    2- StartCaroutine (fonksiyonu()) koduyla �al��t�r�l�r,StopCaroutine(fonksiyonu()) koduyla durdurulur
   


}
