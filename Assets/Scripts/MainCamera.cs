using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {

    public float HorizontalCameraSpeed;
    public float VerticalCameraSpeed;
    public float ZoomSpeed;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(HorizontalCameraSpeed * Time.deltaTime, 0.0f, 0.0f));
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-HorizontalCameraSpeed * Time.deltaTime, 0.0f, 0.0f));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0.0f, 0.0f, VerticalCameraSpeed * Time.deltaTime), Space.World);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0.0f, 0.0f, -VerticalCameraSpeed * Time.deltaTime), Space.World);
        }
	}
}
