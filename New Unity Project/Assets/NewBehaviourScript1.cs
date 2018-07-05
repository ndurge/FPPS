using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    private AudioSource Beau_geluid;

    public AudioClip[] soundClips;

	// Use this for initialization
	void Start ()
    {
        Beau_geluid = (AudioSource)GetComponent (typeof(AudioSource));
	}

    void OnTriggerEnter(Collider collider)
    {
        AudioClip randomClip = soundClips[Random.Range(0, soundClips.Length)];

        Beau_geluid.clip = randomClip;
        Beau_geluid.Play();
    }
    // Update is called once per frame
    void Update () {
		
	}
}
