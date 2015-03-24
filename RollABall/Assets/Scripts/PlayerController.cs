using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public Rigidbody rBody;
	public float speed;

	public ScoreController scoreController;

	void Start()
	{

	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
		rBody.AddForce(movement * Time.deltaTime * speed);
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("Touching");
		if( other.gameObject.tag == "Pickup" )
		{
			other.gameObject.SetActive(false);
			scoreController.UpdateScore();
		}
	}
}