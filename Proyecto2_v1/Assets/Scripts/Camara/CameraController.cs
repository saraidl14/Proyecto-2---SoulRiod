using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] protected Camera _camera; // Haciendo _camera protegida para que los hijos puedan acceder
    public Transform target; // Objeto al que seguir, si lo hay
    public float distance = 5.0f; // Distancia inicial entre la c�mara y el jugador
    public float height = 2.0f; // Altura relativa de la c�mara al jugador
    public float rotationSpeed = 5.0f; // Velocidad de rotaci�n de la c�mara

    protected void Update()
    {
        if (target != null)
        {
            // Si hay un objetivo, posiciona la c�mara mirando hacia el objetivo
            transform.LookAt(target);
        }
        else
        {
            // Si no hay un objetivo, puedes establecer una posici�n arbitraria
            // Aqu� un ejemplo de c�mo mover la c�mara en el eje Z
            transform.position = new Vector3(0f, 0f, -10f);
        }
    }
}
