using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvakontrol : MonoBehaviour
{
    public GameObject canvas; // Kapat�lacak Canvas nesnesi

    void Start()
    {
        // �lk ba�ta Canvas'� kapal� konumda ba�lat
        //canvas.SetActive(false);
    }

    public void ToggleCanvas()
    {
        // Butona bas�ld���nda �a�r�lacak fonksiyon
        canvas.SetActive(!canvas.activeSelf); // Canvas'� a��ksa kapat, kapal�ysa a�
    }
}
