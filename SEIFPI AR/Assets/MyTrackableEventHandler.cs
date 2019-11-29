using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTrackableEventHandler : DefaultTrackableEventHandler
{
    // reference to my rotate script component
    public RotateScript rotateScript;

    protected override void Start()
    {
        base.Start();
    }

    protected override void OnDestroy()
    {
        base.OnDestroy();
    }

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        rotateScript.canRotate = true;
    }


    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        rotateScript.canRotate = false;
    }
}
