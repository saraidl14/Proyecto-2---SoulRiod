using Unity.VisualScripting;
using UnityEngine;

public class FollowPlayerRotation : CameraController // Heredar de CameraController la posicion 
{
    // No necesitas declarar nuevamente los par�metros, ya que los heredas de CameraController

    private float currentRotationX = 0.0f;

    void LateUpdate()
    {
        if (!target) // "target" viene de CameraController
            return;

        // Calcula la rotaci�n horizontal de la c�mara basada en el movimiento del rat�n
        currentRotationX += Input.GetAxis("Mouse X") * rotationSpeed; // "rotationSpeed" viene de CameraController

        // Limita la rotaci�n vertical entre ciertos l�mites (para evitar voltear la c�mara hacia arriba o hacia abajo demasiado)
        currentRotationX = Mathf.Clamp(currentRotationX, -80f, 80f);

        // Calcula la rotaci�n y posici�n de la c�mara basada en la rotaci�n horizontal y la posici�n del jugador
        Quaternion rotation = Quaternion.Euler(0, currentRotationX, 0);
        Vector3 negDistance = new Vector3(0.0f, height, -distance);
        Vector3 position = rotation * negDistance + target.position; // "height" y "distance" vienen de CameraController

        // Aplica la rotaci�n y la posici�n a la c�mara
        _camera.transform.rotation = rotation; // "_camera" viene de CameraController
        _camera.transform.position = position; // "_camera" viene de CameraController
    }
}
