using UnityEngine;
using UnityEngine.AI;

public class ChaseTarget : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private bool chase;
    private NavMeshAgent agent;
    private MeshRenderer meshRenderer;
    

    public void DoChase(bool option, Color color, ITargeteable targetRecived) // Metodo candidato para el Action
    {
        chase = option;
        meshRenderer.material.color = color;

        target = targetRecived.GetMyTransform();
    }

    #region Unity Fuctions Event
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnEnable()
    {
       MasterDelegate.OnTargetAppears += DoChase;
    }

    void Update()
    {
        if(chase) 
            agent.destination = target.position;
    }

    private void OnDisable()
    {
        MasterDelegate.OnTargetAppears -= DoChase;
    }
    #endregion
}
