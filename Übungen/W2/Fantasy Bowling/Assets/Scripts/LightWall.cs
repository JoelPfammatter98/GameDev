using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightWall : MonoBehaviour
{
    [SerializeField] private Light _light;
    [SerializeField] private MeshRenderer _meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        _light.enabled = false;
        _meshRenderer.enabled = false;   
    }

    private void OnTriggerEnter(Collider other) {
        _light.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
