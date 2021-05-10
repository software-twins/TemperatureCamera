using System;
using UnityEngine;

public class CanvasLine : MonoBehaviour
	{
    	public Color c1 = Color.red;
    	public Color c2 = Color.white;
    	Vector3 topPoint;
    	Vector3 bottomPoint;

    // Start is called before the first frame update
    void Start()
    {
        topPoint = new Vector3(Screen.width / 4, Screen.height);
        bottomPoint = new Vector3(Screen.width / 4, 0);
        LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.widthMultiplier = 2.2f;
        lineRenderer.positionCount = 40;

        // A simple 2 color gradient with a fixed alpha of 1.0f.
        float alpha = 1.0f;
        Gradient gradient = new Gradient();
        gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(c1, 0.0f), new GradientColorKey(c2, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) }
        );
        lineRenderer.colorGradient = gradient;

        lineRenderer.SetPosition(0, topPoint);
        lineRenderer.SetPosition(1, bottomPoint);
    }


}

