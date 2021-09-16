using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoTest : MonoBehaviour
{
    public RenderTexture rt;
    public VideoClip clip;
    void Start()
    {

        Debug.Log("OnEnable");
        VideoPlayer vp = new VideoPlayer();
        //vp.source = VideoSource.VideoClip;
        vp.clip = clip;
        vp.targetTexture = rt;
        vp.isLooping = true;
        vp.audioOutputMode = VideoAudioOutputMode.Direct;
        vp.SetDirectAudioMute(0, true);

    }
}
