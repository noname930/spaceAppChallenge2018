using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTo_Y : MonoBehaviour {

    private float speed = 3f;
    private float height = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        Vector2 pos = transform.position;
        //calculate what the new Y position will be
        float newY = Mathf.Sin(Time.time * speed);
        //set the object's Y to the new calculated Y
        transform.position = new Vector3(pos.x, newY) * height;


    }
}
