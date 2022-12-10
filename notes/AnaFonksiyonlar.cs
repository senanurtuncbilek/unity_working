using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaFonksiyonlar : MonoBehaviour
{
   /* 
   
    Awake() --> oyun çalýþmaya baþladýðýnda ilk önce ve 1 kez çalýþýr
    Start() --> oyun çalýþmaya baþladýðýnda awakeden sonra 1 kez çalýþýr
    Update() --> awake ve starttan sonra ve SÜREKLÝ çalýþýr,çalýþma hýza cihaza göre deðiþir
    FixedUpdate() --> awake ve starttan sonra ve Sürekli çalýþýr,çalýþma hýzý sabit,fizikle alakalý kodlarda kullanýlýr
    LateUpdate() --> hepsinden sonra ve SÜREKLÝ çalýþýr, hýzý cihaza göre deðiþir
}
