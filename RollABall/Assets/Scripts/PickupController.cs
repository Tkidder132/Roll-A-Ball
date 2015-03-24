using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickupController : MonoBehaviour 
{

	public GameObject Pickup;
	List<GameObject> PickupList = new List<GameObject>();

	bool creationNeeded;

	// Use this for initialization
	void Start ()
	{
		GameObject PickupParent = GameObject.FindGameObjectWithTag("PickupParent");
		for( int i = 0; i < 12; i++ )
		{
			PickupList.Add(Instantiate(Pickup));

			PickupList[i].transform.parent = PickupParent.transform;
			Vector3 spawnPoint = new Vector3((float)Random.Range(-9,9), .5f, (float)Random.Range(-9,9));
			PickupList[i].transform.position = spawnPoint;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		CreatePickups();
	}

	void CreatePickups()
	{
		for( int i = 0; i < PickupList.Count; i++ )
		{
			if( !PickupList[i].activeSelf )
			{
				Vector3 spawnPoint = new Vector3((float)Random.Range(-9,9), .5f, (float)Random.Range(-9,9));
				PickupList[i].transform.position = spawnPoint;
				PickupList[i].SetActive(true);
			}
		}
	}
}
