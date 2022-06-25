using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    // Start is called before the first frame update
    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position,0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
