using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    GameObject MainCube;
    int height;

    void Start()
    {
        MainCube = GameObject.Find("MainCube");
    }
    
    // Update is called once per frame
    void Update()
    {
        MainCube.transform.position= new Vector3(transform.position.x,height + 1,transform.position.z);
        this.transform.localPosition= new Vector3(0, -height, 0);
    }
    
     public void DecreaseHeight()
    {
        height--;
    }
    
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Collect" && other.gameObject.GetComponent<CollectableCubes>().GetisCollected()==false)
        {
            height += 1;
            other.gameObject.GetComponent<CollectableCubes>().makeCollected();
            other.gameObject.GetComponent<CollectableCubes>().setIndex(height);
            other.gameObject.transform.parent= MainCube.transform;

        } 
    }
}
