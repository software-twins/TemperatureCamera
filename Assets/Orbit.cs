using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class Orbit : MonoBehaviour
	{
    	public Camera cam;

		// Start is called before the first frame update
    	void Start ()
    		{
				cam.transform.LookAt (targetObject, Vector3.up);
			}
     	
    	public Transform targetObject;
		public float 	 orbitSpeed = 10.0f, moveSpeed = 3.0f;

		private float scroll, delta;

    	// Update is called once per frame
    	void Update ()
    		{
				if ( Input.GetMouseButton (0) ) 
					{
    					delta = Input.GetAxis ("Mouse X");
        				cam.transform.RotateAround (targetObject.transform.position, Vector3.up, delta * orbitSpeed);
    				}
		 
				scroll = Input.GetAxis ("Vertical") * .01f; //; //("Mouse ScrollWheel");
           		cam.transform.Translate (0, 0, scroll, Space.Self);

				if ( Input.GetMouseButton (2) ) 
					{
						delta = Input.GetAxis ("Mouse X");
        				cam.transform.Translate (0.01f * delta * moveSpeed, 0, 0, Space.Self);
    				}
    		}
	}
