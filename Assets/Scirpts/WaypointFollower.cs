using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypoinntIndex = 0;

    [SerializeField] private float speed = 2f;
    private void Update()
    {
        if (UnityEngine.Vector2.Distance(waypoints[currentWaypoinntIndex].transform.position, transform.position) < .1f)
        {
            currentWaypoinntIndex++;
            if (currentWaypoinntIndex >= waypoints.Length)
            {
                currentWaypoinntIndex = 0;
            }
        }
        transform.position = UnityEngine.Vector2.MoveTowards(transform.position, waypoints[currentWaypoinntIndex].transform.position, Time.deltaTime * speed);
    }
}
