using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootmanMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform[] _waypoints;
    private int _currentPoint;

    private void Awake()
    {
        _waypoints = GetComponentInParent<WaypointsSetter>().Waypoints;
    }

    private void Update()
    {
        Transform target = _waypoints[_currentPoint];
 
        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);
        transform.LookAt(target.position);

        if (transform.position == target.position && _currentPoint < _waypoints.Length - 1)
            _currentPoint++;
    }

}
