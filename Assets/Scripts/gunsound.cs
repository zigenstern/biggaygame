
using UnityEngine;

public class gunsound : MonoBehaviour
{
	public AudioClip GunSound;
 void Start()
    {GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = GunSound;
        
    }
    void Update()
    {
		if(Input.GetKeyDown("Fire1"))
		GetComponent<AudioSource>().Play();
        
    }
}
