using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2 : MonoBehaviour
{
    public static P2 col2;
    public bool p2collided;
    // Start is called before the first frame update
    void Start()
    {
        col2 = this;
        p2collided = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "p2collider")
        {
            Debug.Log("collided player's card");
            p2collided = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.name == "p2collider")
        {
            p2collided = false;
        }
    }*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "p2")
        {
            p2collided = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "p2")
        {
            p2collided = false;
        }
    }
}
