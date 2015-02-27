﻿using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Car")
		{
			CarControlScript.coinCounter++;
			Destroy(this.gameObject);
		}
	}

}