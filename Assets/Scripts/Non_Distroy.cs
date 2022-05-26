using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Non_Distroy : MonoBehaviour
{
    void Start () 
    {
     //offset = transform.position - player.transform.position;
    }
    private void onCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="UpperBlock")
        {
            Destroy(collision.gameObject);
        }
    }
}

