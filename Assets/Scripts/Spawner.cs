using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points; 
    public float beat = (60/130)*2;
    private float timer; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer>beat)
        {
            GameObject cube = Instantiate(cubes[Random.Range(0,2)], points[Random.Range(0,4)]);
            // Creates an instance of the prefabs you have assigned to the "cubes" array
            // the instance is named "cube"
            // the instance can come out of any of the "SpawnPoint" game objects
            cube.transform.localPosition = Vector3.zero; 
            // sets child in the same positon as parent object 
            // in this case the child the instance of named "cube"
            // and the parent is the respective  "SpawnPoint" game object it came out of 
            cube.transform.Rotate(transform.forward, 90 * Random.Range(0,4));
            // The spawned cube is going to be rotated on the Z axis (noted by "transform.forward")
            // the amount it gets rotated on the Z axis is by random increment (multiples) of 90 denoted by "90 * Random.Range(0,4)"
            // depending on where you map is oriented on the coordinate plan you may need to adjust transform.forward
            cube.transform.Rotate(0f, 180f, 0f);
            // cube is oriented backward when spawn so rotate them 180 to face player 
            timer -= beat;
        }

        timer += Time.deltaTime;

        // still have to rationalize the time and the beat 
    }
}
