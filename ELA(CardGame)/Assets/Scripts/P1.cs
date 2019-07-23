using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1 : MonoBehaviour
{
    public static P1 col1;
    public bool p1collided;
    // Start is called before the first frame update
    void Start()
    {
        col1 = this;
        p1collided = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "p1collider")
        {
            Debug.Log("collided player1's card");
            p1collided = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.name == "p1collider")
        {
            p1collided = false;
        }
    }*/
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.tag == "p1")
        {
            p1collided = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "p1")
        {
            p1collided = false;
        }
    }
}
