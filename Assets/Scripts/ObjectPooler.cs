using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{

    [System.Serializable] //ensures that the reusing of objects will show up in the inspector
    public class Pool
    { // moves Pool into inspector so things don't need to be changed manually 
        public string tag;
        public GameObject prefab; //stores the prefab of the objects in that pool 
        public int size; // stores the total size of the pool 
    }

    public static ObjectPooler Instance;

    private void Awake()
    {
        Instance = this;
    }

    public List<Pool> pools; // shows the List of pools in the inspector 

    public Dictionary<string, Queue<GameObject>> poolDictionary; // names the dictionary 'pool dictionary' for reference in script, labels the key type as a string and stores the pool as a queue
    void Start()
    {

        poolDictionary = new Dictionary<string, Queue<GameObject>>(); // references pool dictionary in the Start update 

        foreach (Pool pool in pools)
        { //loops through each pool 
            Queue<GameObject> objectPool = new Queue<GameObject>(); // creates a queue of game objects, defines it as objectpool, and sets it equal to a new queue of game objects

            for (int i = 0; i < pool.size; i++)
            { //continues to loop for as long as i is less than pool.size, instantiating as many objects as we've defined in the inspector in the size box
                GameObject obj = Instantiate(pool.prefab); // defines each object that is instantiated 
                obj.SetActive(false); // disables the object within the queue
                objectPool.Enqueue(obj); // adds the object to the queue 
            }
            // the above basically creates a queue full of objects and ensures that they are all added to the queue 

            poolDictionary.Add(pool.tag, objectPool); //adds the above pool to the dictionary 
        }
    }

    public GameObject SpawnFromPool(string tag, Vector3 position, Quaternion rotation)
    { //takes the inactive cubes and spawns them into the active world
      //contains tag for the object we want to spawn, the position of the object and the rotation of the object 

        if (!poolDictionary.ContainsKey(tag))
        { //makes sure that if a tag isn't given, an error is thrown 
            Debug.LogWarning("Pool with tag " + tag + " doesn't exist."); // the error that is thrown if the 
            return null; //returns null in the case that there is no object 
        }

        GameObject objecttoSpawn = poolDictionary[tag].Dequeue(); //references the queue and pulls the first item within the queue 

        objecttoSpawn.SetActive(true); //configures the above referenced objectospawn to active
        objecttoSpawn.transform.position = position; //moves the object to the appropriate position 
        objecttoSpawn.transform.rotation = rotation; //rotates the object appropriately 

        poolDictionary[tag].Enqueue(objecttoSpawn); // adds it back to the queue for reuse later 

        return objecttoSpawn; // ensures we can grab the object from where we spawned it 
    }
}