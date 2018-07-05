using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Draw : MonoBehaviour, IVirtualButtonEventHandler{
    private bool isPressed = false;
    public GameObject VBtn;
    public GameObject Paint;
    public GameObject Brush;
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        isPressed = true;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        isPressed = false;
    }

    // Use this for initialization
    void Start () {
        VBtn = GameObject.Find("VButton");
        Brush = GameObject.Find("brush");
        VBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
	
	// Update is called once per frame
	void Update () {
		if (isPressed == true)
        {
            Instantiate(Paint, Brush.transform.position, Brush.transform.rotation);
        }
	}
}
