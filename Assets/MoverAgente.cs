using UnityEngine;
using UnityEngine.AI;

public class MoverAgente : MonoBehaviour
{
    public NavMeshAgent agente;
    public Transform destino;

    void Start()
    {
        // Aseg�rate de que el agente est� asignado
        if (agente == null)
            agente = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Actualiza la posici�n del agente hacia el destino
        if (destino != null)
            agente.SetDestination(destino.position);
    }
}
