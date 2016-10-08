using UnityEngine;
using System.Collections;

public class BGMManager : MonoBehaviour {

	public AudioClip menuBGM;

	private AudioSource menuSource;

	public AudioSource AddAudio(AudioClip clip, bool loop, bool playAwake, float vol)
	{
		AudioSource newAudio = gameObject.AddComponent<AudioSource> ();
		newAudio.clip = clip;
		newAudio.loop = loop;
		newAudio.playOnAwake = playAwake;
		newAudio.volume = vol;

		return newAudio;
	}

	void Awake()
	{
		menuSource = AddAudio (menuBGM, true, false, 1.0f);
		menuSource.Play ();
	}
}
