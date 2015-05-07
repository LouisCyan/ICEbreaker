using UnityEngine;
using System.Collections;

public class KaraAudio : MonoBehaviour {
    public enum whichSound { noHashTag,  prettySight, ok, getStarted};
    public AudioClip[] audio;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PlayASound(whichSound sound)
    {
        switch (sound)
        {
            case whichSound.noHashTag:
                gameObject.GetComponent<AudioSource>().clip = audio[0];
                gameObject.GetComponent<AudioSource>().Play();
                break;
            case whichSound.prettySight:
                gameObject.GetComponent<AudioSource>().clip = audio[1];
                gameObject.GetComponent<AudioSource>().Play();
                break;
            case whichSound.ok:
                gameObject.GetComponent<AudioSource>().clip = audio[2];
                gameObject.GetComponent<AudioSource>().Play();
                break;
            case whichSound.getStarted:
                gameObject.GetComponent<AudioSource>().clip = audio[3];
                gameObject.GetComponent<AudioSource>().Play();
                break;
        }
    }
}
