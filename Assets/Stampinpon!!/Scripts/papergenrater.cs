using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class papergenrater : MonoBehaviour
{
    public GameObject prefab;
    public void papergenerate()
    {
        Instantiate(prefab, new Vector3(0.0f, 0.4f, -2.0f), Quaternion.identity);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            papergenerate();
        }
    }
    
}
