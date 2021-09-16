using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.VFX.Utility;
using UnityEngine.Video;


public class JpBinder : VFXBinderBase
{
    public RTTest rttest;

    public override bool IsValid(VisualEffect component)
    {
        return rttest != null;
    }
    public override void UpdateBinding(VisualEffect component)
    {
        component.SetTexture("mainTexture", rttest._rt);
    }
}
