using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public Transform shootFromPos;
    public float damage;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) shoot();
    }

    void shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(shootFromPos.position,Camera.main.transform.forward,out hit, Mathf.Infinity))
        {
            if(hit.transform.tag=="Enemy") hit.transform.gameObject.GetComponent<enemy>().health -= damage;
        }
    }

}
