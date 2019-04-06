using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingManger : MonoBehaviour
{
    public Waypoint[] waypointLocations;
    
    void Start()
    {
       waypointLocations = FindObjectsOfType<Waypoint>();
       Debug.Log(waypointLocations + " : " + waypointLocations.Length);
    }

    
    void Update()
    {
        
    }
}
