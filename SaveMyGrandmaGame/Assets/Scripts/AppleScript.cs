using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleScript : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D col)
	{
		GameControlScript.moneyAmount += 1;
		Destroy(gameObject);
	}
}
