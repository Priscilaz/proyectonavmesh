using UnityEngine;
using UnityEngine.AI;

public class MoverAgente : MonoBehaviour
{
    public NavMeshAgent agente;
    public Transform destino;

    void Start()
    {
        // Asegúrate de que el agente esté asignado
        if (agente == null)
            agente = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Actualiza la posición del agente hacia el destino
        if (destino != null)
            agente.SetDestination(destino.position);
    }
}
