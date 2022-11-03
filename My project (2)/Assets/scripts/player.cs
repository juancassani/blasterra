using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Vector3 posInicial;
    public float speed = 15f;
    void Start(){
        posInicial = transform.position;
    }
    void Update()
    {
        Movimiento();
        if(transform.position.y < -20){
            respawn();
        }
    }
    void respawn()
    {
        transform.position = posInicial;

    }
    void Movimiento()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");

        Vector3 move = transform.right * movX + transform.forward * movY;
        transform.Translate(new Vector3(movX, 0, movY) * speed * Time.deltaTime);

        
    }
}
