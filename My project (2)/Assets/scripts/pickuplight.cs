using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickuplight : MonoBehaviour
{
    public GameObject playerlight;
    public GameObject light;
    // Start is called before the first frame update
    void Start()
    {
        playerlight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.transform.gameObject.name == "light")
        {
            Destroy(col.transform.gameObject);
            playerlight.SetActive(true);
        }
    }
}
