using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTheme : MonoBehaviour
{
    [SerializeField] static SoundTheme soundTheme;
    private void Awake()
    {
        if (soundTheme == null)
        {
            soundTheme = this;
            DontDestroyOnLoad(soundTheme);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
