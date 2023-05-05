using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class chase : MonoBehaviour
{
    public Transform[] goal;
    private int goalCOunter;
    private NavMeshAgent agent;
    private int i=1;

    void Start()
    {
        goalCOunter = goal.Length;
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.pathStatus== NavMeshPathStatus.PathComplete  && agent.remainingDistance<0.5)
        {
            agent.destination = goal[i].position;
            i++;
            if (i == goalCOunter)
            {
                i = 0;
            }
        }
    }
}
