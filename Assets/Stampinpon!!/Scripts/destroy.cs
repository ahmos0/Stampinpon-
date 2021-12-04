using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy: MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
	{
		// 衝突した相手にPlayerタグが付いているとき
		Debug.Log("test");
		if (collision.gameObject.tag == "Hanko")
		{

			Destroy(gameObject, 0.0f);
		}
	}
}
