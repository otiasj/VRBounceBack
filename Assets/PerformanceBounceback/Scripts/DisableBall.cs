using UnityEngine;
using System.Collections;

public class DisableBall : MonoBehaviour
{
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.CompareTag("Ground")) {
			Invoke("Disable", 4.5f);
		}
	}

	private void Disable()
	{
		gameObject.SetActive(false);
	}
}

