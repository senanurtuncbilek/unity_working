using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionSes: MonoBehaviour
{
    static AudioSource ses;

    private void Start()
    {
        ses = GetComponent<AudioSource>();
    }

    // carpisma gerceklestiginde ses dosyasýnýn calismasi icin.

     void OnCollisionEnter(Collider kure)
    {
        if (kure.gameObject.tag == "kure");
        {
            ses.Play();
            Debug.Log("AKTÝF");
          
        }
    }
}
