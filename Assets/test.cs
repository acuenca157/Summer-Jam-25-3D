using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour, IEasyListener
{
    public void OnBeat(EasyEvent currentAudioEvent)
    {
        Debug.Log(currentAudioEvent.CurrentBeat);
    }
}
