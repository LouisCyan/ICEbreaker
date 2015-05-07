using UnityEngine;
using System.Collections;

public class MainControl : MonoBehaviour {
    public ChrisAV chrisAV;
    public KaraAudio karaAudio;
    public AudioSource firewall;
    public AudioClip dataExplode, fireAlarm;
    public enum firewallSounds { explode, alarm };

    public AudioSource dataClick;

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

    public void FirewallPlaySount(MainControl.firewallSounds sound)
    {
        switch (sound)
        {
            case firewallSounds.alarm:
                firewall.clip = fireAlarm;
                firewall.Play();
                break;
            case firewallSounds.explode:
                firewall.clip = dataExplode;
                firewall.Play();
                break;
        }
    }

    public void DataClickSound()
    {
        dataClick.Play();
    }
}
