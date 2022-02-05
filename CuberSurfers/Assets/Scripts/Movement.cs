using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;
    [SerializeField]
    private float rightLeftSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalAxis=Input.GetAxis("Horizontal")*rightLeftSpeed*Time.deltaTime;
        this.transform.Translate(horizontalAxis,0,movementSpeed*Time.deltaTime);
    }
}
