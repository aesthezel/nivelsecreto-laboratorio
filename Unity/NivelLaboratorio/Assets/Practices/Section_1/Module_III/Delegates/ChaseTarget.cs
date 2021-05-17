
using UnityEngine;
using UnityEngine.AI;

public class ChaseTarget : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private bool chase;
    private NavMeshAgent agent;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void OnEnable() // Se ejecuta cuando el GameObject es Active
    {
       MasterDelegate.OnDoAnything += DoChase; 
    }

    // Update is called once per frame
    void Update()
    {
        if(chase == true) 
            agent.destination = target.position;
    }

    private void OnDisable() // Se ejecuta cuando el GameObject es Active
    {
        MasterDelegate.OnDoAnything -= DoChase;
    }

    public void DoChase()
    {
        chase = true;
    }
}
