using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Jugador : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 10f;
    private Rigidbody rb;

    void Start() => rb = GetComponent<Rigidbody>();

    void Update()
    {
        Vector3 movimiento = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocidad * Time.deltaTime;
        transform.Translate(movimiento);

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.01f)
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
    }

}
