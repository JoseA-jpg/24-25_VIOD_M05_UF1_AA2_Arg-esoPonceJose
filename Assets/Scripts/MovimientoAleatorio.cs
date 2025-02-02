using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAleatorio : MonoBehaviour
{
    public Rigidbody2D rb;
    public float FuerzaMin = 3f;//Esta variable nos permitir� establecer la fuerza m�nima del asteroide
    public float FuerzaMax = 12f;//Esta variable nos permitir� establecer la fuerza m�xima del asteroide
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float fuerza = Random.Range(FuerzaMin, FuerzaMax);

        Vector3 direccion = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f)); //Creamos una direcci�n aleatoria para crear la fuerza

        rb.AddForce(direccion * fuerza, ForceMode2D.Impulse); //A�adimos la fuerza al asteroide
        //El ForceMode2D.Impulse nos permite a�adir una fuerza instant�nea al asteroide en vez de una fuerza constante dependiendo de la masa del objeto
        float RotacionAleatoria = Random.Range(0f, 360f);
        transform.rotation = Quaternion.Euler(0, 0, RotacionAleatoria); //Rotamos el asteroide en el eje Z que es el unico que podemos ver en 2D
        //El Quaternion.Euler es una rotaci�n de 4 dimensiones (x,y,z,w) que nos permite rotar el objeto en los 3 ejes, en este caso solo rotamos en el eje Z

    }
}
