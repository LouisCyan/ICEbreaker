using UnityEngine;
using System.Collections;

public class junkRotate : MonoBehaviour {
    public bool rotate;
    public Vector3 turnSpeed;
    Vector3 currentAngle;


	// Use this for initialization
	void Start () {
        currentAngle = new Vector3 (transform.localRotation.x, transform.localRotation.y, transform.localRotation.z);
	
	}
	
	// Update is called once per frame
	void Update () {
        
        if (rotate)
        {
            currentAngle += turnSpeed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(currentAngle);
        }
	
	}
}
