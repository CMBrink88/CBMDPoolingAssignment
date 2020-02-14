using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
// defines the movement parameters for the cube that the objectpooler spawns within the scene
{
    public float upForce = 1f; // defines the force that the cube moves upwards as 1f 
    public float sideForce = .1f; // defines the force that the cube moves side to side as 1f 

    void Start()
    {
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upForce / 2f, upForce);
        float zForce = Random.Range(-sideForce, sideForce); // calculates a random force for the movement of the cube along the x, y, and z axis

        Vector3 force = new Vector3(xForce, yForce, zForce);

        GetComponent<Rigidbody>().velocity = force; // adds the random calculated force to the cube's rigidbody 

    }

}
