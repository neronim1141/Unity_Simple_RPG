using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : MonoBehaviour,IInputController {

    public Vector2 InputVector {
        get{
            return new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        }
        }
    public bool ButtonOne {get{ 
            if (Input.GetButton("Fire1"))
                return true;
            else
                return false;
            } }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
}
