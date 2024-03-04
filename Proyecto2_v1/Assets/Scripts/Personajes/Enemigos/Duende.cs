using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duende : EnemyController
{
    // Atributos adicionales espec�ficos de Duende (si es necesario)

    // M�todo para inicializar los atributos espec�ficos
    void Start()
    {
        // Inicializar vida y estado inicial aqu�
        vidaMaxima = 100f;
        vidaActual = vidaMaxima;
        CambiarEstado(estados[0]); // Iniciar en estado "Idle"
    }

    // Implementaci�n del comportamiento de patrullar espec�fico para Duende
    void Patrullar()
    {
        // Implementaci�n de movimiento aleatorio
        Debug.Log("Duende patrullando...");
    }

    // Implementaci�n del comportamiento de rastrear espec�fico para Duende
    void Rastrear()
    {
        // Implementaci�n de seguimiento al jugador
        Debug.Log("Duende rastreando al jugador...");
    }

    // Implementaci�n del comportamiento de atacar espec�fico para Duende
    void Atacar()
    {
        // Implementaci�n de ataque al jugador
        Debug.Log("Duende atacando al jugador...");
    }

    // Override de m�todo RecibirDa�o para a�adir comportamiento espec�fico de Duende
    public override void RecibirDanio(float cantidad)
    {
        base.RecibirDanio(cantidad);
        Debug.Log("El Duende recibi� da�o.");
    }
}
