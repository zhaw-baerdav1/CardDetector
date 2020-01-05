using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCalculatorTrackableEventHandler : DefaultTrackableEventHandler
{
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        
        CalculatorDetectedObjectList.AddDetectedObject(base.mTrackableBehaviour.TrackableName);
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        CalculatorDetectedObjectList.RemoveDetectedObject(base.mTrackableBehaviour.TrackableName);
    }
}
