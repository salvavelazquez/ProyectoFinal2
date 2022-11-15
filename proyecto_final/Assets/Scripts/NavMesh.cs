using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public GameObject goalDestination;
    public GameObject player;
    public GameObject submarino;

    // Update is called once per frame
    void Start()
    {
        navMeshAgent.destination = goalDestination.transform.position;
        player.SetActive(false);
        submarino.SetActive(false);
    }
}