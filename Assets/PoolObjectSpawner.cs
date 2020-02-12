//Christopher Brinkley and Morgan Davis
//MMC215 Pooling Assignment
//2/14/20
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObjectSpawner(){
    
    CbrinkleyMDavisPoolingProject objectPooler;

    private void Start(){
        objectPooler = CbrinkleyMDavisPoolingProject.Instance; //Stores object in a variable on start of program
    }

    void FixedUpdate(){
        
        CbrinkleyMDavisPoolingProject.Instance.SpawnFromPool("Cube", transform.position, Quaternion.identity); //Creates the object from the pool into the program
    }
}