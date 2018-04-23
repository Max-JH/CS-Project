using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour {

    [SerializeField]
    Transform platform;
    [SerializeField]
    Transform floor1;
    [SerializeField]
    Transform floor2;
    [SerializeField]
    Transform floor3;
    [SerializeField]
    Transform floor4;
    [SerializeField]
    float platformSpeed;

    Vector3 direction;
    Transform destination;


    void Start()
    {
        SetDestination(floor1);
    }

    void FixedUpdate()
    {
        platform.GetComponent<Rigidbody>().MovePosition(platform.position + direction * platformSpeed * Time.fixedDeltaTime);
        if(Vector3.Distance (platform.position, destination.position) < platformSpeed * Time.fixedDeltaTime)
        {
            SetDestination(destination == floor1 ? floor2 : floor1);
        }
    }
    void OnDrawGizmos() 
    {
        Gizmos.DrawWireCube(floor1.position, platform.localScale);
        Gizmos.DrawWireCube(floor2.position, platform.localScale);
        Gizmos.DrawWireCube(floor3.position, platform.localScale);
        Gizmos.DrawWireCube(floor4.position, platform.localScale);
    }   
    void SetDestination(Transform dest)
    {
        destination = dest;
        direction = (destination.position - platform.position).normalized;
    }
}