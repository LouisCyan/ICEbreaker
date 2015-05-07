using UnityEngine;
using System.Collections;

public class MainControl : MonoBehaviour {
    public ChrisAV chrisAV;
    public KaraAudio karaAudio;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PlayChrisVideo(ChrisAV.whichVideo video)
    {
        chrisAV.SetVideo(video);
    }

    public void PlayChrisAudio(ChrisAV.whichSound sound)
    {
        chrisAV.PlayASound(sound);
    }

    public void PlayKaraAudio(KaraAudio.whichSound sound)
    {
        karaAudio.PlayASound(sound);
    }
}
