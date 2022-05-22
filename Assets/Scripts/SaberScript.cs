using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaberScript : MonoBehaviour
{

public LayerMask layer;
private Vector3 previousPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        {
            if(Vector3.Angle(transform.position - previousPos, hit.transform.up)>130)
            {
                Destroy(hit.transform.gameObject);
            }
            previousPos = transform.position;
        }

        // you have to rationalize this entire script 
        // seems like Valem assigns this script to the hand controller 
        // Can this same script work if I assigned it to the saber game object and then use the OnCollision method?

        // Also need to find out: Whats the difference between a layer and a tag? are they just different ways to subgroup things?

        
    }
}
