using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinding : MonoBehaviour
{
    public Transform[] points;

    private UnityEngine.AI.NavMeshAgent nav;
    private int destPoint;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called one or more per frame
    void FixedUpdate()
    {
        if (!nav.pathPending && nav.remainingDistance < 0.5f)
            GoToNextPoint();
    }
    void GoToNextPoint()
    {
        if (points.Length == 0)
        {
            return;
        }
        nav.destination = points[destPoint].position;
        destPoint = (destPoint + 1) % points.Length;
    }
}
