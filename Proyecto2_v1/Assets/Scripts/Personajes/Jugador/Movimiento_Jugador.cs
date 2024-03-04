using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Jugador : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 10f;
    public float tiempoMaxPulsacion = 0.5f;
    private Rigidbody rb;
    private bool estaCorriendo = false;
    private float tiempoUltPulsacion = 0f;

    void Start() 
    { 
        rb = GetComponent<Rigidbody>(); 
    }

    void Update()
    {
       
        if(/*Input.GetAxis("Horizontal")*/  Input.GetKeyUp(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) ) 
        {
            float tiempoTranscurrido = Time.time - tiempoUltPulsacion;
            if (tiempoTranscurrido <= tiempoMaxPulsacion)
            {
                estaCorriendo = !estaCorriendo; // Alternar entre correr y caminar
            } tiempoTranscurrido = Time.time;
        }

        float multiplicadorVelocidad = estaCorriendo ? 2f : 1f; // Si está corriendo, multiplicar la velocidad
        Vector3 movimiento = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocidad * multiplicadorVelocidad * Time.deltaTime;
        transform.Translate(movimiento);

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.01f)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }
           
    }

}
