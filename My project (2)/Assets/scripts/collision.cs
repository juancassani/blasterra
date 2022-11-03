using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public GameObject player;
    public Vector3 defaultSize;
    public float timer = 0f;
    public bool big;
    public Vector3 bigSize = new Vector3 (2, 2, 2);
    void Start()
    {
        defaultSize = player.transform.localScale;
    }


    void Update()
    {
        canChange();
    }

    void OnTriggerExit(Collider col)
    {        
        if(col.transform.gameObject.name == "goldenwall")
        {
            Destroy(col.transform.gameObject);
            Debug.Log("goldenwall");

            
        } // destruir la pared

        if(col.transform.gameObject.name == "transformador")
        {
            if(timer < 0 && big == false)
            {
                transform.localScale = new Vector3(4, 4, 4);
                // transform.position += new Vector3(2, 2, 0);
                Debug.Log("big guy");
                big = true;
                timer = 3f;
                
            }
        }
    }
    void OnTriggerEnter(Collider other){
        if(other.transform.gameObject.name == "transformador")
        {
            if(timer < 0 && big == true)
            {
                transform.localScale = new Vector3(1 , 1, 1);
                Debug.Log("small guy");
                big = false;
                Debug.Log(big);
                timer = 3f;
            }
        }
    }
    void canChange()
    {
        timer -= 1 * Time.deltaTime;
    }
    
}
