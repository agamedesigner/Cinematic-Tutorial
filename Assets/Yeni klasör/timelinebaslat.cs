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
        // Ýlk baþta Timeline'ý durdur
        playableDirector.Stop();
    }

    public void StartTimeline()
    {
        // Düðme týklandýðýnda çaðrýlacak fonksiyon
        playableDirector.Play();
    }
}
