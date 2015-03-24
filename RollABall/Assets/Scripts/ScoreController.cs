using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
	public GameObject score;
	int scoreValue = 0;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		score.gameObject.GetComponent<Text>().text = "Score: " + scoreValue.ToString();
	}

	public void UpdateScore()
	{
		this.scoreValue += 10;
	}
}
