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

    // M�todo para cambiar de estado
    protected virtual void CambiarEstado(string nuevoEstado)
    {
        estadoActual = nuevoEstado;
        Debug.Log("Estado actual: " + estadoActual);
    }

    // M�todo para recibir da�o
    public virtual void RecibirDanio(float cantidad)
    {
        vidaActual -= cantidad;
        Debug.Log("Vida actual: " + vidaActual);
        if (vidaActual <= 0)
        {
            Morir();
        }
    }

    // M�todo para la muerte del enemigo
    protected virtual void Morir()
    {
        Debug.Log("El enemigo ha muerto.");
        Destroy(gameObject);
    }
}
