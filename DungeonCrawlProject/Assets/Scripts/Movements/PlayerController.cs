using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Charaktermovement {

    public float speed = 1;

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Horizontal")!=0 || Input.GetAxis("Vertical") != 0)
        {
            Move((new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")))*speed);
        }
        else
        {
            Idle();
        }
    }
}
