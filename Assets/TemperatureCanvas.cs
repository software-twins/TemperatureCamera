using System;

using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(CanvasScaler ), typeof(GraphicRaycaster))]

public class TemperatureCanvas : MonoBehaviour
	{
		public Camera cam;

		private Canvas canvas;
		private Text text;

 		void Start	()
    		{
        		// Get canvas from the GameObject.
        		canvas = GetComponent <Canvas> ();
        		canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        		// Create the Text GameObject.
        		GameObject t = new GameObject ();
        		t.transform.parent = canvas.transform;
				text = t.AddComponent <Text> ();
				//t.AddComponent <CanvasRenderer> ();

        		// Set Text component properties.
        		//text = t.GetComponent<Text>();

				Font arial = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");

				text.color = Color.black;
        		text.font = arial;
        		//text.text = "Press space key";
        		text.fontSize = 14;
        		//text.alignment = TextAnchor.MiddleCenter;

        		// Provide Text position and size using RectTransform.
        		RectTransform rectTransform;
        		rectTransform = text.GetComponent <RectTransform> ();
        		rectTransform.localPosition = new Vector3 (-313, 182, 0);
        		rectTransform.sizeDelta = new Vector2 (427, 164);
    		}

    
		void FixedUpdate ()
    		{
				// Bit shift the index of the layer (8) to get a bit mask
//        		int layerMask = 1 << 8;

        		// This would cast rays only against colliders in layer 8.
        		// But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
  //      		layerMask = ~layerMask;

				RectTransform r = GetComponent <RectTransform> ();

  				Vector3 center = cam.transform.position; //ScreenToWorldPoint (new Vector3 (r.rect.width / 2, 
												//					  r.rect.height / 2,
												//		 			  cam.nearClipPlane));

				//Debug.Log ("center " + center + " " + r.rect.width + " " + r.rect.height);
				//Debug.DrawRay (center, transform.TransformDirection(Vector3.forward) * 1000, 
				//					   Color.green);

				var obj = new object ();

        		RaycastHit hit;
        		// Does the ray intersect any objects excluding the player layer
        		if (Physics.Raycast (center, transform.TransformDirection(Vector3.forward), 
									 out hit))
        			{
            			//Debug.DrawRay (center, 
						//			   transform.TransformDirection(Vector3.forward) * hit.distance, 
						//			   Color.yellow);
						obj = hit.transform.gameObject;
        			}
        		else
        			{
            			//Debug.DrawRay (center, 
						//			   transform.TransformDirection(Vector3.forward) * 1000, Color.red);

        			}
			
				text.text = "object: " + obj + 
							"\n" +
							"distance: " + hit.distance +
							"\n" +
							"center: " + center;	
			}

		void Update()
    		{
			//	text.text = "Press space key";
       
    		}
	}
	

