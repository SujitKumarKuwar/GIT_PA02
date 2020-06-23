using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject[] Objectss;
    float PostitionX;
    // Start is called before the first frame update
    void Start()
    {
         InvokeRepeating("SpawnObjects", 1, 1);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void SpawnObjects()
    {
        int randomNumber;
        randomNumber = Random.Range(0, Objectss.Length);
        PostitionX = Random.Range(1.55f, -1.55f);
        this.transform.position = new Vector3(PostitionX, transform.position.y, transform.position.z);
        Instantiate(Objectss[randomNumber], transform.position, transform.rotation);
    }
}
