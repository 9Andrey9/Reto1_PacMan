using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    public VideoPlayer videoplayer;
    // Start is called before the first frame update
    void Start()
    {
        videoplayer = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        videoplayer.url = System.IO.Path.Combine (Application.streamingAssetsPath,"cinematica1.mp4");
        videoplayer.Play();
    }
}
