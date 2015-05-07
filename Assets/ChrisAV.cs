using UnityEngine;
using System.Collections;

public class ChrisAV : MonoBehaviour {
    public enum whichSound { firewall, freePizza };
    public AudioClip[] audio;
    public enum whichVideo { noVideo, junkData, iCanWork };
    public Material[] vidMat;
    public Renderer videoPlane;
    public MovieTexture movie;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SetVideo(whichVideo.junkData);
        }
	
	}

    public void PlayASound(whichSound sound)
    {
        switch (sound)
        {
            case whichSound.firewall:
                gameObject.GetComponent<AudioSource>().clip = audio[0];
                gameObject.GetComponent<AudioSource>().Play();
                break;
            case whichSound.freePizza:
                gameObject.GetComponent<AudioSource>().clip = audio[1];
                gameObject.GetComponent<AudioSource>().Play();
                break;
        }
    }

    public void SetVideo(whichVideo video)
    {
        
        switch (video)
        {
            case whichVideo.noVideo:
                videoPlane.material = vidMat[0];
                break;
            case whichVideo.junkData:
                videoPlane.material = vidMat[1];
                movie = (MovieTexture)videoPlane.material.mainTexture;
                movie.Play();
                Invoke("StopMovie", movie.duration);
                gameObject.GetComponent<AudioSource>().clip = audio[2];
                gameObject.GetComponent<AudioSource>().Play();
                break;
            case whichVideo.iCanWork:
                videoPlane.material = vidMat[2];
                movie = (MovieTexture)videoPlane.material.mainTexture;
                movie.Play();
                Invoke("StopMovie", movie.duration);
                gameObject.GetComponent<AudioSource>().clip = audio[3];
                gameObject.GetComponent<AudioSource>().Play();
                break;
        }
        
    }

    void StopMovie()
    {
        movie.Stop();
        SetVideo(whichVideo.noVideo);
    }
}
