using UnityEngine;
using System.Collections.Generic;
public class AudioList : MonoBehaviour
{
    public List<AudioClip> ListClips = new List<AudioClip>();
    public AudioSource audioSource;

    [SerializeField] private bool loopPlayList = true;
    private int currentIndex = -1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayNext()
    {
        if (ListClips == null || ListClips.Count == 0 || audioSource == null)
            return;
        currentIndex++;
        if (currentIndex >= ListClips.Count)
        {
            if (loopPlayList == true)
            {
                currentIndex = 0;
            }
            else
            {
                currentIndex = ListClips.Count - 1;
                return;
            }
        }
        

        audioSource.Stop();
        audioSource.clip= ListClips[currentIndex];
        audioSource.Play();
        
    }



}
