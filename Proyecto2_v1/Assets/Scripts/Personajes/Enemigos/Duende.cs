using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duende : EnemyController
{
    // Atributos adicionales específicos de Duende (si es necesario)

    // Método para inicializar los atributos específicos
    void Start()
    {
        // Inicializar vida y estado inicial aquí
        vidaMaxima = 100f;
        vidaActual = vidaMaxima;
        CambiarEstado(estados[0]); // Iniciar en estado "Idle"
    }

    // Implementación del comportamiento de patrullar específico para Duende
    void Patrullar()
    {
        // Implementación de movimiento aleatorio
        Debug.Log("Duende patrullando...");
    }

    // Implementación del comportamiento de rastrear específico para Duende
    void Rastrear()
    {
        // Implementación de seguimiento al jugador
        Debug.Log("Duende rastreando al jugador...");
    }

    // Implementación del comportamiento de atacar específico para Duende
    void Atacar()
    {
        // Implementación de ataque al jugador
        Debug.Log("Duende atacando al jugador...");
    }

    // Override de método RecibirDaño para añadir comportamiento específico de Duende
    public override void RecibirDanio(float cantidad)
    {
        base.RecibirDanio(cantidad);
        Debug.Log("El Duende recibió daño.");
    }
}
