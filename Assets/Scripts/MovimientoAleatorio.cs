using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAleatorio : MonoBehaviour
{
    public Rigidbody2D rb;
    public float FuerzaMin = 3f;//Esta variable nos permitirá establecer la fuerza mínima del asteroide
    public float FuerzaMax = 12f;//Esta variable nos permitirá establecer la fuerza máxima del asteroide
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float fuerza = Random.Range(FuerzaMin, FuerzaMax);

        Vector3 direccion = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f)); //Creamos una dirección aleatoria para crear la fuerza

        rb.AddForce(direccion * fuerza, ForceMode2D.Impulse); //Añadimos la fuerza al asteroide
        //El ForceMode2D.Impulse nos permite añadir una fuerza instantánea al asteroide en vez de una fuerza constante dependiendo de la masa del objeto
        float RotacionAleatoria = Random.Range(0f, 360f);
        transform.rotation = Quaternion.Euler(0, 0, RotacionAleatoria); //Rotamos el asteroide en el eje Z que es el unico que podemos ver en 2D
        //El Quaternion.Euler es una rotación de 4 dimensiones (x,y,z,w) que nos permite rotar el objeto en los 3 ejes, en este caso solo rotamos en el eje Z

    }
}
