using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaFonksiyonlar : MonoBehaviour
{
   /* 
   
    Awake() --> oyun �al��maya ba�lad���nda ilk �nce ve 1 kez �al���r
    Start() --> oyun �al��maya ba�lad���nda awakeden sonra 1 kez �al���r
    Update() --> awake ve starttan sonra ve S�REKL� �al���r,�al��ma h�za cihaza g�re de�i�ir
    FixedUpdate() --> awake ve starttan sonra ve S�rekli �al���r,�al��ma h�z� sabit,fizikle alakal� kodlarda kullan�l�r
    LateUpdate() --> hepsinden sonra ve S�REKL� �al���r, h�z� cihaza g�re de�i�ir
}
