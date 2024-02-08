using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavController : MonoBehaviour
{
    private NavMeshAgent agent;
    public float margin = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void SetTarget(Vector3 target)
    {
        if(Vector3.Distance(transform.position,target) > margin)
        {
            agent.SetDestination(target);
        }
    }
}
