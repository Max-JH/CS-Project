using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour {

    public GameObject projectile;
    public Transform camera;
    public float velocity;
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject g = Instantiate(projectile) as GameObject;
            g.transform.position = transform.position + camera.forward * 2;
            Rigidbody body = g.GetComponent<Rigidbody>();
            body.velocity = camera.forward * velocity;
            Destroy(g, 20);
        }
    }
}
