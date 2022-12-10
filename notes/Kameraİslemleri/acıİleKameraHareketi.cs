using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aciIleKameraHareketi : MonoBehaviour
{
    public GameObject KameraHareketi;
    Vector3 Kamera_Set;

    private void FixedUpdate()
    {
        if(KameraHareketi.transform.eulerAngels.x>10) //aci 10dan buyuk oldugunda
        {
            Kamera_Set = (KameraHareketi.transform.position - transform.position).normalized;
            //game objenin icine yerlestirilen camera icin play tusuna basýldýgýnda bir miktar pozisyonda oynama olur.
            //bu kodla baslangic koordinatýna getirdik.
            Kamera_Set.Set(Kamera_Set.x, 0, Kamera_Set.z); //x ve z ekseninde hareket sagladik.
            transform.position += Kamera_Set * Time.deltaTime; 
            

        }
    }




}
