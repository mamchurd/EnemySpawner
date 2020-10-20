using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointsSetter : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;

    public Transform[] Waypoints => _waypoints;
}
