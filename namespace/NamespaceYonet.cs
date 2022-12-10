using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using olustur1; //olusturdugumuz namespacesi bu dosyaya dahil ediyoruz.
using olustur2;

public class NamespaceYonet : MonoBehaviour
{
    sinif1 sinif1 = new sinif1();
    sinif2 sinif2 = new sinif2();

    private void Start()
    {
        sinif1.metot1(23);
        sinif2.metot2(8);


    }
}
