using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallArtillery : MonoBehaviour
{
    public AudioSource artillerySound;
    public AudioSource voiceSound;

    public ObjectSnapper snapperRef;

    public FadeScreen fadeScreen;

    public GameObject completeText;

    void Start()
    {
        artillerySound = GameObject.Find("ArtillerySoundLoc").GetComponent<AudioSource>();
        voiceSound = GameObject.Find("Talking").GetComponent<AudioSource>();

        fadeScreen = GetComponent<FadeScreen>();
    }

    void OnTriggerEnter(Collider other)
    {
        bool allObjectsSnapped = snapperRef.allObjectsSnapped;
        
        if (other.CompareTag("Head") && snapperRef.allObjectsSnapped)
        {
            Debug.Log("Phone to head");
            if (artillerySound != null && !artillerySound.isPlaying)
            {
                fadeScreen.FadeOut();
                voiceSound.Play();

                Invoke("EnableAudio", 2f);
                Invoke("EnableText", 2f);
            }
        }
    }

    void EnableAudio()
    {
        artillerySound.Play();
    }

    void EnableText()
    {
        completeText.SetActive(true);
    }

}
