using System;

using UnityEngine;
using UnityEngine.UI;
using TMPro;

[ RequireComponent (typeof (CanvasScaler ), typeof (GraphicRaycaster)) ]

public class TemperatureCanvas : MonoBehaviour
	{
		public Camera cam;

		private Canvas canvas;
		private Vector2 size;

		private TextInfo geometryinfo, parameterinfo;
		private Scale scale;

		GameObject obj1, obj2, obj3;

	    // Start is called before the first frame update
    	void Start()
    		{
 				/** get canvas from the GameObject */
        		canvas = GetComponent <Canvas> ();
				canvas.renderMode = RenderMode.ScreenSpaceCamera;
	
				size = new Vector2 (0, 0); //canvas.pixelRect.width, canvas.pixelRect.height);
			
				obj1 = new GameObject ();
				obj1.transform.parent = canvas.transform;

				/** set text component properties */
				geometryinfo = (obj1.AddComponent (Type.GetType ("TextInfo")) as TextInfo).initialize (-27, 6);

				obj2 = new GameObject ();
				obj2.transform.parent = canvas.transform;

				/** set text component properties */
				parameterinfo = (obj2.AddComponent (Type.GetType ("TextInfo")) as TextInfo).initialize (30, -6); 

				obj3 = new GameObject ();
				obj3.transform.parent = canvas.transform;

				/** set text component properties */
				scale = (obj3.AddComponent (Type.GetType ("Scale")) as Scale).initialize (); 
			}

		void Update ()
			{
				Vector2 s = new Vector2 (canvas.pixelRect.width, canvas.pixelRect.height);

				if ( size != s )
					{
						size = s;
						obj1.GetComponent <CanvasObject> ().geometry (canvas.pixelRect);
						obj2.GetComponent <CanvasObject> ().geometry (canvas.pixelRect);
						obj3.GetComponent <CanvasObject> ().geometry (canvas.pixelRect);
					}

				/** provide text position and size using RectTransform */
        		//RectTransform textransform = geometry.GetComponent <RectTransform> ();
        		
				/** set text position */
				//textransform.localPosition = new Vector3 (-1 * canvas.pixelRect.width  / 4.0f,
				//										  1 * canvas.pixelRect.height / 4.0f,
				//										  0);
        		/** set text box dimensions */
		
				//Vector2 size = new Vector2 (27 * 12, 5 * 16);
				//textransform.sizeDelta = size;
			}

		public void show (Info info)
    		{
				//Debug.Log ("in sgow");			
				//text.text = text1; //"object: " + obj + 
				//			"\n" +
				//			"distance: " + hit.distance +
				//			"\n" +
				//			"center: " + center;	
				//geometry.SetText ("The first number is {0} and the 2nd is {1:2} and the 3rd is {3:0}.",
				//4, 6.345f, 3.5f);
				//	int width = (int) ((4.0f * canvas.pixelRect.width / 10.0f) / 10.0f);
				//	Debug.Log ("width : " + width);
  				geometryinfo.text (String.Format (
								   "{1,-20}{2,7}\n\n{3,-20}{4,7:0.000}\n{5,-20}{6,7:0.000}\n{7,-20}{8,7:0.000}\n{9,-20}{10,7:0.000}", 
								   0, 
								   "Material :", "Steel",
								   "Length (m) :", info.geometry.length, 
								   "Inner radius (m) :", info.geometry.radius_inner,
								   "Outer radius (m) :", info.geometry.radius_outer, 
								   "Wall thickness (m) :", info.geometry.wall_thick)); //= Stringinfo.tube; //label + (m_frame);
					
				parameterinfo.text (String.Format (
								   "{1,-20}{2,7}\n\n{3,-20}{4,10:0.000000}\n{5,-20}{6,7:0.000}\n{7,-20}{8,7:0.000}\n{9,-20}{10,7:0.000}", 
								   0, 
								   "Substance :", "Water",
								   "Flow rate (m3/s) :", info.parameters.flow_rate, 
								   "In temperature (m) :", info.parameters.in_temperature,
								   "Out temperature (m) :", info.parameters.out_temperature, 
								   "Ambient temperature (m) :", info.parameters.ambient));//temperaturetext.text = info.temperature;
			}
	}
	

