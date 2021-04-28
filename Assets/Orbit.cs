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

			//	FixedUpdate1 ();
    		}

		void FixedUpdate1 ()
    		{
        		// Bit shift the index of the layer (8) to get a bit mask
//        		int layerMask = 1 << 8;

        		// This would cast rays only against colliders in layer 8.
        		// But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
  //      		layerMask = ~layerMask;

				//RectTransform r = GetComponent <RectTransform> ();

  				Vector3 center = cam.transform.position; //ScreenToWorldPoint (new Vector3 (r.rect.width / 2, 
												//					  r.rect.height / 2,
												//		 			  cam.nearClipPlane));

				//Debug.Log ("center " + center + " " + r.rect.width + " " + r.rect.height);
				Debug.DrawRay (center, transform.TransformDirection(Vector3.forward) * 1000, 
									   Color.green);

        		RaycastHit hit;
        		// Does the ray intersect any objects excluding the player layer
        		if (Physics.Raycast (center, transform.TransformDirection(Vector3.forward), 
									 out hit))
        			{
            			Debug.DrawRay (center, 
									   transform.TransformDirection(Vector3.forward) * hit.distance, 
									   Color.yellow);
						var obj = hit.transform.gameObject;
						Debug.Log("Did Hit" + hit.distance + " " + obj);
        			}
        		else
        			{
            			Debug.DrawRay (center, 
									   transform.TransformDirection(Vector3.forward) * 1000, Color.red);
            			Debug.Log("Did not Hit");
        			}
			}
	}
