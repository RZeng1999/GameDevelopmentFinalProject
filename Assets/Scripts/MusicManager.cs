using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    AudioClip backgroundClip;

    static MusicManager _instance=null;

    void Awake() {
        if(_instance==null) {
            _instance=this;

        }
        else{
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    
    void Start()
    {
        AudioSource source = GetComponent<AudioSource>();
        backgroundClip=source.clip;

        if(!source.isPlaying) {
            source.Play();
        }
    }
}
    // Update is called once per frame
