using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Scripts.AI
{
    public class simpleMoveTo : MonoBehaviour
    {
        [SerializeField]
        Transform _destination;

        NavMeshAgent _navMeshAgent;

        // Use this for initialization
        void Start()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            _navMeshAgent.SetDestination(_destination.position);
        }
    }

}