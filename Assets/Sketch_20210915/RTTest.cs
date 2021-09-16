using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class RTTest : MonoBehaviour
{
    [HideInInspector] public RenderTexture _rt;
    private VideoPlayer videoplayer;
    public UnityEngine.UI.RawImage rawImage;

    void Start()
    {
        _rt = new RenderTexture(256, 114, 0, RenderTextureFormat.ARGB32);
        _rt.wrapMode = TextureWrapMode.Clamp;
        _rt.filterMode = FilterMode.Point;

        videoplayer = GetComponent<VideoPlayer>();
        videoplayer.targetTexture = _rt;
        rawImage.texture = _rt;
    }
}
