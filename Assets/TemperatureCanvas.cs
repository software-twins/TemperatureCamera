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
        		/** get canvas from the GameObject */
        		canvas = GetComponent <Canvas> ();
        		canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        		/** create the text GameObject */
        		GameObject obj = new GameObject ();
        		obj.transform.parent = canvas.transform;
				text = obj.AddComponent <Text> ();
				
        		/** set text component properties */
        		text.fontSize = 14;
				text.color = Color.black;
        		text.font = (Font) Resources.GetBuiltinResource (typeof (Font), "Arial.ttf");
        		
        		/** provide text position and size using RectTransform */
        		RectTransform textransform = text.GetComponent <RectTransform> ();
        		
				/** set text position */
				textransform.localPosition = new Vector3 (-canvas.pixelRect.width / 4.0f, canvas.pixelRect.height / 4.0f, 0);
        		/** set text box dimensions */
				textransform.sizeDelta = new Vector2 (3.0f * canvas.pixelRect.width / 10.0f, 3.0f * canvas.pixelRect.height / 10.0f);
    		}

    
	public void show (String text1)
    		{
			text.text = text1; //"object: " + obj + 
				//			"\n" +
				//			"distance: " + hit.distance +
				//			"\n" +
				//			"center: " + center;	
			}
	}
	

