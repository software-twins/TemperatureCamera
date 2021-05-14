using System;

using UnityEngine;
using UnityEngine.UI;
using TMPro;

[ RequireComponent (typeof (Image)) ] //, typeof (Image)) ]

public class Scale : CanvasObject
	{
		private Image img1, img2;

		void Start ()
			{
				GameObject obj1 = new GameObject ();
				obj1.transform.parent = gameObject.transform;
		
       			img1 = obj1.AddComponent <Image> ();
				img1.color = Color.red;
					
				GameObject obj2 = new GameObject ();
				obj2.transform.parent = gameObject.transform;
		
       			img2 = obj2.AddComponent <Image> ();
				img2.color = Color.red;
				
			}
	
		override public void geometry (Rect rect)
			{
				RectTransform t = img1.GetComponent <RectTransform> ();
				
		t.anchoredPosition =  new Vector2 (rect.width / 2.0f, rect.height / 2.0f);
				t.sizeDelta = new Vector2 (rect.height, 2f);
				t.localEulerAngles = new Vector3 (0, 0, 90f);

				RectTransform t2 = img2.GetComponent <RectTransform> ();
				
				t2.anchoredPosition =  new Vector2 (rect.width / 2.0f, rect.height / 2.0f); //canvas.pixelRect.height / 2.0f);
				t2.sizeDelta = new Vector2 (rect.width, 2f);
			}

		public Scale initialize ()
			{
								
				return this;
			}
	}
	

