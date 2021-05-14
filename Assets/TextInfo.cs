using System;

using UnityEngine;
using UnityEngine.UI;
using TMPro;

[ RequireComponent (typeof (TextMeshProUGUI)) ] //, typeof (Image)) ]

public class CanvasObject : MonoBehaviour
	{
		public Rect rect;
		virtual public void geometry (Rect rect)
			{
				Debug.Log ("in update textInfo----214");
			}
	}

public class TextInfo : CanvasObject
	{
		private Image image;
		private TextMeshProUGUI info;

		public int linelength, linesnumber;

		void Start ()
			{
				GameObject obj = new GameObject ();
				obj.transform.parent = gameObject.transform;

				(image = obj.AddComponent <Image> ()).color = new Vector4 (0.0f, 0.0f, 1.0f, 0.05f); 

				info = GetComponent <TextMeshProUGUI> ();
				/** Make sure the Anton SDF exists before calling this */
				info.font = Resources.Load ("Font/Electronic Highway Sign SDF", typeof (TMP_FontAsset)) 
								as TMP_FontAsset;
              
				info.alignment = TextAlignmentOptions.Left;
       			info.extraPadding = true;
			}
	
		override public void geometry (Rect rect)
			{
				info.fontSize = (16 * rect.width / 835.0f);
				
				Vector2 size = new Vector2 (0.51f * Math.Abs (linelength) * info.fontSize, 
											Math.Abs (linesnumber) * info.fontSize);
								
				/** provide text position and size using RectTransform */
        		RectTransform transform;

				/** set text position */
				transform = info.GetComponent <RectTransform> ();

        		/** set text position */
				transform.localPosition = new Vector3 (Math.Sign (linelength) * rect.width / 4.0f, 
													   Math.Sign (linesnumber) * rect.height / 4.0f, 
													   0.0f);
        		/** set text box dimensions */
				transform.sizeDelta = size;
				
				/** set text position */
				transform = image.GetComponent <RectTransform> ();
				
				/** set text position */
				transform.localPosition = new Vector3 (0.0f, 0.0f, 0.0f); 
			    /** set text box dimensions */
				transform.sizeDelta = size + new Vector2 (info.fontSize, info.fontSize); 
			}

		public TextInfo initialize (int x, int y)
			{
				linelength = x;
				linesnumber = y;
				
				return this;
			}

		public float fontSize () 
			{
				return info.fontSize / 2;
			}
		
		public void text (String str)
    		{
				info.text = str;
			}
	}
	

