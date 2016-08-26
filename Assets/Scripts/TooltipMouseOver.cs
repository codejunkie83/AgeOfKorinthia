using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TooltipMouseOver : MonoBehaviour {
    bool Hovering;
    Canvas canvas;
	// Use this for initialization
	void Start ()
    {
        canvas = gameObject.GetComponentInChildren<Canvas>(true);
        Hovering = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        canvas.enabled = Hovering;
	}

    void OnMouseEnter()
    {
        Hovering = true;
    }

    void OnMouseExit()
    {
        Hovering = false;
    }
}
