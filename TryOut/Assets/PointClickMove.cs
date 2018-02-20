using UnityEngine;

public class PointClickMove : MonoBehaviour
{

    private NavMeshAgent mNavMeshAgent;

    // Use this for initialization
    void Start()
    {
        mNavMeshAgent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                mNavMeshAgent.destination = hit.point;
            }
        }

        if (mNavMeshAgent.remainingDistance <= mNavMeshAgent.stoppingDistance)
        {

        }
    }
}
