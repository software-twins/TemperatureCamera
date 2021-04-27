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
        		text.text = "Press space key";
        		text.fontSize = 28;
        		text.alignment = TextAnchor.MiddleCenter;

        		// Provide Text position and size using RectTransform.
        		RectTransform rectTransform;
        		rectTransform = text.GetComponent <RectTransform> ();
        		rectTransform.localPosition = new Vector3 (00, 00, 0);
        		//rectTransform.sizeDelta = new Vector2 (150, 80);
    		}

    	void Update()
    		{
				text.text = "Press space key";
       
    		}
	}
	

