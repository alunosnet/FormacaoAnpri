using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils
{ 
    public static bool CanYouSeeThis(Vector3 positionFrom, Vector3 positionTo)
    {
        RaycastHit hit;
        var rayDirection = positionTo - positionFrom;
        Debug.DrawRay(positionFrom, rayDirection, Color.blue);
        if (Physics.Raycast(positionFrom, rayDirection, out hit))
        {
            return (hit.transform.position == positionTo);
        }
        return false;
    }
}
