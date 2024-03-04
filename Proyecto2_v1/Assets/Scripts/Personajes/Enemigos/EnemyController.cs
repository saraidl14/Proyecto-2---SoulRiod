using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Atributos heredables
    protected string[] estados = { "Idle", "Patrullando", "Rastreando", "Atacando" };
    protected string estadoActual;
    protected float vidaMaxima;
    protected float vidaActual;

    // Método para cambiar de estado
    protected virtual void CambiarEstado(string nuevoEstado)
    {
        estadoActual = nuevoEstado;
        Debug.Log("Estado actual: " + estadoActual);
    }

    // Método para recibir daño
    public virtual void RecibirDanio(float cantidad)
    {
        vidaActual -= cantidad;
        Debug.Log("Vida actual: " + vidaActual);
        if (vidaActual <= 0)
        {
            Morir();
        }
    }

    // Método para la muerte del enemigo
    protected virtual void Morir()
    {
        Debug.Log("El enemigo ha muerto.");
        Destroy(gameObject);
    }
}
