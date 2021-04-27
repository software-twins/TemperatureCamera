using System;

using UnityEngine;
using UnityEngine.UI;

public class TemperatureCanvas : MonoBehaviour
	{
		public Camera camera;

		private Canvas canvas;

 		void Start	()
    		{
        		// Get canvas from the GameObject.
        Canvas canvas;
        canvas = canvasGO.GetComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        // Create the Text GameObject.
        GameObject textGO = new GameObject();
        textGO.transform.parent = canvasGO.transform;
        textGO.AddComponent<Text>();

        // Set Text component properties.
        text = textGO.GetComponent<Text>();
        text.font = arial;
        text.text = "Press space key";
        text.fontSize = 48;
        text.alignment = TextAnchor.MiddleCenter;

        // Provide Text position and size using RectTransform.
        RectTransform rectTransform;
        rectTransform = text.GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector3(0, 0, 0);
        rectTransform.sizeDelta = new Vector2(600, 200);
    }

    void Update()
    {
        // Press the space key to change the Text message.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (textChanged != UpDown.Down)
            {
                text.text = "Text changed";
                textChanged = UpDown.Down;
            }
            else
            {
                text.text = "Text changed back";
                textChanged = UpDown.Up;
            }
        }
    }
}
	}

