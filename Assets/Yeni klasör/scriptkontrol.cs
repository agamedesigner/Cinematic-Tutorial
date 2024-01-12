using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class scriptkontrol : MonoBehaviour
{
    public void aktif()
    {
        GetComponent<karakterkontrol>().enabled=true;
    }
}
