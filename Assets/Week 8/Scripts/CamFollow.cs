using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : vThirdPersonCamera
{
    public override void SetMainTarget(Transform newTarget)
    {
        base.SetMainTarget(newTarget);
        Debug.Log("Camera now following: " + newTarget.name);
    }
}
