using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaras : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cambiarcamara();   
    }
    void cambiarcamara()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.E)){
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
            
        }
        if (Input.GetKeyDown(KeyCode.R)){
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
        }
        
    }
}
