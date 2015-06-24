using UnityEngine;
using System.Collections;

public class CaptainController : MonoBehaviour 
{
	private Animator animator;

	// Use this for initialization
	void Start () 
	{
		animator = transform.FindChild ("CaptainSprite").GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.A))
			animator.SetTrigger ("Jump");
		else if (Input.GetKeyDown (KeyCode.S))
			animator.SetTrigger ("Slide");
	}
}
