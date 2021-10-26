using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    public GameObject exp;
    private void OnTriggerEnter(Collider other)
    {
        Vector3 swapnPos=new Vector3(other.gameObject.transform.position.x,4,other.gameObject.transform.position.z);
        GameObject e = Instantiate(exp, swapnPos, exp.gameObject.transform.rotation);
        Destroy(e, 1.0f);
        //Destroy(gameObject);
    }
}
