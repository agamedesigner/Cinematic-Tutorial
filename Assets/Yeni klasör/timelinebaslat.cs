using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class timelinebaslat : MonoBehaviour
{
    public PlayableDirector playableDirector;

    void Start()
    {
        // �lk ba�ta Timeline'� durdur
        playableDirector.Stop();
    }

    public void StartTimeline()
    {
        // D��me t�kland���nda �a�r�lacak fonksiyon
        playableDirector.Play();
    }
}
