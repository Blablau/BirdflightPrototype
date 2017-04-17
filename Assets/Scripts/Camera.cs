using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public GameObject target;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    // More preferred Update-Method for Cameras (gets called after Player calculation)
    void LateUpdate()
    {
        transform.LookAt(target.transform);
    }
}
