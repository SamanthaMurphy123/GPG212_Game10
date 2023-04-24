using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitcher : MonoBehaviour
{
    public string playerTag = "Player";
    public AudioSource[] musicSources;
    public AudioSource triggerSource;

    private bool hasTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(playerTag) && !hasTriggered)
        {
            hasTriggered = true;

            // Disable all existing music sources
            foreach (AudioSource source in musicSources)
            {
                source.Stop();
            }

            // Play the trigger music audio source
            triggerSource.Play();
        }
    }
}
