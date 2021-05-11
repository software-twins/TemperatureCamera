using System;

using UnityEngine;
using UnityEngine.UI;
using TMPro;

[ RequireComponent (typeof (CanvasScaler ), typeof (GraphicRaycaster)) ]

public class TemperatureCanvas : MonoBehaviour
	{
		public Camera cam;

		private Canvas canvas;
		private Vector2 canvasize;

		private TextMeshProUGUI geometry, parameters;
		private TextInfo geometryinfo;

		GameObject obj;

		private void /*TextMeshProUGUI*/create_textmesh (String name, int x, int y)
			{
				obj = new GameObject ();

				obj.name = name;
        		obj.transform.parent = canvas.transform;

				/** set text component properties */
				//Type name = Type.GetType ("TextInfo");
				TextInfo textinfo = obj.AddComponent (Type.GetType ("TextInfo")) as TextInfo;
                
				/** Make sure the Anton SDF exists before calling this */
			//	textmesh.font = Resources.Load ("Font/Electronic Highway Sign SDF", typeof (TMP_FontAsset)) 
			//					as TMP_FontAsset;
              
			//	textmesh.fontSize = (int) (16 * Math.Min (canvas.pixelRect.width, 
			//												canvas.pixelRect.height) / 440.0f);                
			//	textmesh.alignment = TextAlignmentOptions.Left;
       		//	textmesh.extraPadding = true;

			//	obj = new GameObject ();
			//	obj.transform.parent = canvas.transform;
		
       		//	Image img = obj.AddComponent <Image> ();
			//	img.color = new Vector4 (0.0f, 0.0f, 1.0f, 0.05f);// Color.yellow;

			//	Vector3 center = new Vector3 (Math.Sign (x) * canvas.pixelRect.width  / 4.0f, 
			//								  Math.Sign (y) * canvas.pixelRect.height / 4.0f, 
			//								  0);
				
			//	float b = textmesh.fontSize * 12 / 16;

			//	Vector2 size = new Vector2 (Math.Abs (x) * b, Math.Abs (y) * textmesh.fontSize);

				/** provide text position and size using RectTransform */
        	//	RectTransform transform;

			//	transform = textmesh.GetComponent <RectTransform> ();
        		
				/** set text position */
			//	transform.localPosition = center;
        		/** set text box dimensions */
			//	transform.sizeDelta = size;
				
			//	transform = img.GetComponent <RectTransform> ();
				/** set text position */
				
			//	transform.localPosition = center;
			    /** set text box dimensions */
			//	transform.sizeDelta = size + new Vector2 (40, 40);
			
			//	return textmesh;
			}
	
		//public Color c1 = Color.red;
    	//public Color c2 = Color.white;
    	//Vector3 topPoint;
    	//Vector3 bottomPoint;

    // Start is called before the first frame update
    	void Start()
    		{
 				/** get canvas from the GameObject */
        		canvas = GetComponent <Canvas> ();
				canvasize = new Vector2 (canvas.pixelRect.width, canvas.pixelRect.height);
			
				obj = new GameObject ();
				obj.transform.parent = canvas.transform;

				/** set text component properties */
				//Type name = Type.GetType ("TextInfo");
				TextInfo geometryinfo = obj.AddComponent (Type.GetType ("TextInfo")) as TextInfo;
        	
				//	canvas.renderMode = RenderMode.ScreenSpaceOverlay;

			//	canvasize = new Vector2 (canvas.pixelRect.width, canvas.pixelRect.height);
					
			//	geometry = create_textmesh ("TubeGeometryInfo", -27, 5);

				//obj.transform.parent = canvas.transform;
			
				/*Vector3 top = new Vector3 (canvas.pixelRect.width / 2, canvas.pixelRect.height, 0);
        		Vector3 bottom = new Vector3 (canvas.pixelRect.width / 2, 0, 0);

				GameObject obj = new GameObject ();
				obj.transform.parent = canvas.transform;
		
       			Image img = obj.AddComponent <Image> ();
				img.color = Color.red;

				RectTransform t = img.GetComponent <RectTransform> ();
				
				t.anchoredPosition =  new Vector2 (0, 0); //canvas.pixelRect.height / 2.0f);
				t.sizeDelta = new Vector2 (canvas.pixelRect.height, 2f);
				t.localEulerAngles = new Vector3 (0, 0, 90f);

				GameObject obj1 = new GameObject ();
				obj1.transform.parent = canvas.transform;
		
       			Image img1 = obj1.AddComponent <Image> ();
				img1.color = Color.red;

				RectTransform t1 = img1.GetComponent <RectTransform> ();
				
				t1.anchoredPosition =  new Vector2 (0, 0); //canvas.pixelRect.height / 2.0f);
				t1.sizeDelta = new Vector2 (canvas.pixelRect.width, 2f);

			//	geometry = textmesh (-27, 5);
				//float b = (4.0f * canvas.pixelRect.width / 10.0f) / geometry.textInfo.characterInfo [0].textElement.glyph.metrics.width;
//Debug.Log ("b : " + b);
				//parameters = textmesh (30, -5);*/
    		}

		void Update ()
			{
				Vector2 size = new Vector2 (canvas.pixelRect.width, canvas.pixelRect.height);

				if ( canvasize != size )
					{
			canvasize = size;
								(obj.GetComponent <t1Update> ()).Update1 ();
							
						Debug.Log ("resize on");
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
  			//	geometryinfo.text = String.Format (
			//					"<mspace={0}>{0,-20}{1,7}\n\n{2,-20}{3,7:0.000}\n{4,-20}{5,7:0.000}\n{6,-20}{7,7:0.000}\n{8,-20}{9,7:0.000}</mspace>", 
			//					geometry.fontSize * 12 / 16,
			//					"Material :", "Steel",
			//					"Length (m) :", info.geometry.length, 
			//					"Inner radius (m) :", info.geometry.radius_inner,
			//					"Outer radius (m) :", info.geometry.radius_outer, 
			//					"Wall thickness (m) :", info.geometry.wall_thick); //= Stringinfo.tube; //label + (m_frame);
			
				//temperaturetext.text = info.temperature;

					/*		parameters.text = String.Format ("Substance {1}\n\nFlow rate, m3/s: {2,7:f}\n\nTemperature in, grad: {3,7:f}\nTemperature out, grad: {4,7:f}\nTemperature ambient, grad:{5,7:f}", 
											   10,
											   "Water",
											   info.parameters.flow_rate, 
											   info.parameters.in_temperature,
info.parameters.out_temperature, info.parameters.ambient); //= Stringinfo.tube; //label + (m_frame);*/
				//temperaturetext.text = info.temperature;
			}
	}
	

