using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy: MonoBehaviour
{
	private papergenrater _papergenerater;
	private float timer;
	void Start()
	{
		_papergenerater = GameObject.FindGameObjectWithTag("papergenerater").GetComponent<papergenrater>();
		
	}
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
	{
		// 衝突した相手にPlayerタグが付いているとき
		if (collision.gameObject.tag == "Hanko")
		{
			_papergenerater.papergenerate();
			Destroy(gameObject, 0.0f);
		}
	}	
}
