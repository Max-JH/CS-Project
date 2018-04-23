using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private string planet;
    public void SetGravity(float newGrav)
    {
        Physics.gravity = new Vector3(0, newGrav, 0);
    }
    public float GetGravity()
    {
        return Physics.gravity.y;
    }
    public void SetPlanet(string pName)
    {
        planet = pName;
    }
    public string GetPlanet()
    {
        return planet;
    }
}
