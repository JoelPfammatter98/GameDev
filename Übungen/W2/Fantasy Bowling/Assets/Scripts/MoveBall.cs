using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{ 
    [SerializeField] private float speed = 5f;
    private Rigidbody RigidbodyBall;
    private bool _startShoot = false;

    // Start is called before the first frame update
    void Start()
    {
        RigidbodyBall = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && _startShoot == false) {
            _startShoot = true;
            FixedUpdate();
        }   
    }

    private void FixedUpdate() {
        if(_startShoot) {
            RigidbodyBall.AddForce(new Vector3(0f, 0f, -speed), ForceMode.Impulse);
            _startShoot = false;
        }
    }
}
