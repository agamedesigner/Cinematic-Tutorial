using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvakontrol : MonoBehaviour
{
    public GameObject canvas; // Kapatýlacak Canvas nesnesi

    void Start()
    {
        // Ýlk baþta Canvas'ý kapalý konumda baþlat
        //canvas.SetActive(false);
    }

    public void ToggleCanvas()
    {
        // Butona basýldýðýnda çaðrýlacak fonksiyon
        canvas.SetActive(!canvas.activeSelf); // Canvas'ý açýksa kapat, kapalýysa aç
    }
}
