//This code spawns the cubes for the cube fountain
//Chris Brinkley and Morgan Davis
//MMC215 Pooling Assignment

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script spawns the cube with an object pooler at the start of the scene but does nothing to limit the number of cubes spawned. 
public class CubeSpawner : MonoBehaviour
{
    ObjectPooler objectPooler; // defines the objectpooler as objectpooler for reference within script

    private void Start()
    {
        objectPooler = ObjectPooler.Instance; // when the scene is started, an objectpooler is presented 
    }

    void FixedUpdate()
    {
        objectPooler.SpawnFromPool("Cube", transform.position, Quaternion.identity); // every fixed update call a cube is instantiated
    }


}
