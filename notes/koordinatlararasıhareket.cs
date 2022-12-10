using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koordinatlararasıhareket : MonoBehaviour
{
    /*   
        
    SABİT HAREKET: "Vector3.MoveTowards(başlangıçkoor.,bitişkoor.,hız);"
    YUMUŞAK HAREKET: "Vector3.Lerp(başlangıçkoor.,bitişkoor.,hız);"


    NESNEYE GÖRE AÇI DEĞİŞİMİ

    nesne.transform.LookAt(hedef_nesne.transform);
    -->LookAt() fonksiyonu,nesnenin "z" açısını hedef nesneye çevirir


}
