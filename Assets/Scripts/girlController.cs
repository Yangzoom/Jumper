using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class girlController : MonoBehaviour {
	private Rigidbody2D myRigidBody;
	public float girlJumpForce = 500f;

	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp("Jump")){
		myRigidBody.AddForce(transform.up * girlJumpForce);
	 }
   }
}