using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound=50;
    public float downBound=-50;

    private void Update() {
    if(transform.position.z <downBound || transform.position.z >50){
        Destroy(gameObject);
    }
    }
}
