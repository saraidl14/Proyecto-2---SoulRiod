using Unity.VisualScripting;
using UnityEngine;

public class FollowPlayerRotation : CameraController // Heredar de CameraController la posicion 
{
    // No necesitas declarar nuevamente los parámetros, ya que los heredas de CameraController

    private float currentRotationX = 0.0f;

    void LateUpdate()
    {
        if (!target) // "target" viene de CameraController
            return;

        // Calcula la rotación horizontal de la cámara basada en el movimiento del ratón
        currentRotationX += Input.GetAxis("Mouse X") * rotationSpeed; // "rotationSpeed" viene de CameraController

        // Limita la rotación vertical entre ciertos límites (para evitar voltear la cámara hacia arriba o hacia abajo demasiado)
        currentRotationX = Mathf.Clamp(currentRotationX, -80f, 80f);

        // Calcula la rotación y posición de la cámara basada en la rotación horizontal y la posición del jugador
        Quaternion rotation = Quaternion.Euler(0, currentRotationX, 0);
        Vector3 negDistance = new Vector3(0.0f, height, -distance);
        Vector3 position = rotation * negDistance + target.position; // "height" y "distance" vienen de CameraController

        // Aplica la rotación y la posición a la cámara
        _camera.transform.rotation = rotation; // "_camera" viene de CameraController
        _camera.transform.position = position; // "_camera" viene de CameraController
    }
}
