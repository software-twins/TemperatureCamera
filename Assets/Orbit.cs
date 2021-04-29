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

    	// Update is called once per frame
    	void Update ()
    		{
				if ( Input.GetMouseButton (0) ) 
					{
    					float delta = Input.GetAxis ("Mouse X");
        				cam.transform.RotateAround (targetObject.transform.position, Vector3.up, delta * orbitSpeed);
    				}
		 
				float scroll = Input.GetAxis ("Vertical") * .01f; //; //("Mouse ScrollWheel");
           		cam.transform.Translate (0, 0, scroll, Space.Self);

				if ( Input.GetMouseButton (2) ) 
					{
						float delta = Input.GetAxis ("Mouse X");
        				cam.transform.Translate (0.01f * delta * moveSpeed, 0, 0, Space.Self);
    				}

				/** get camera center for determining which object looks camera at */
				Vector3 center = cam.transform.position;

				RaycastHit hit;

        		/** does the ray intersect any objects excluding the player layer */
        		if (Physics.Raycast (center, transform.TransformDirection (Vector3.forward), out hit))
					{
        				Debug.Log (" --- " + hit.transform.gameObject.name + " " + hit.transform.gameObject.tag);
						hit.transform.gameObject.SendMessage ("info", 0, SendMessageOptions.DontRequireReceiver);
					}
    		}
	}
