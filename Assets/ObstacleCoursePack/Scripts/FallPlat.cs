using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlat : MonoBehaviour
{
	public float fallTime = 0.5f;
	public GameObject childplatform;
	void OnTriggerEnter(Collider collider)
	{

			if (collider.gameObject.tag == "Player")
			{
				StartCoroutine(Fall(fallTime));
			}
	}

	IEnumerator Fall(float time)
	{
		yield return new WaitForSeconds(time);
		childplatform.SetActive(false);
		yield return new WaitForSeconds(time);
		childplatform.SetActive(true);
	}
}
