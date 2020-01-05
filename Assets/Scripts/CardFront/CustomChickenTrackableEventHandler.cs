using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomChickenTrackableEventHandler : DefaultTrackableEventHandler
{

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        ChickenDetectedObjectList.AddDetectedObject(this.GetHashCode());
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        ChickenDetectedObjectList.RemoveDetectedObject(this.GetHashCode());
    }
}
