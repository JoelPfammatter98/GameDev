using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{ 
    [SerializeField] private float speed = 5f;
    private Rigidbody RigidbodyBall;

    // Start is called before the first frame update
    void Start()
    {
        RigidbodyBall = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
