using UnityEngine;
using System.Collections;

public class CharMove : MonoBehaviour {
	bool isGrounded = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Horizontal")>0){
			transform.Translate(Vector2.right * Time.deltaTime * 3);
		}
		else if (Input.GetAxis("Horizontal")<0){
			transform.Translate(-Vector2.right * Time.deltaTime * 3);
		}
	}
}
