using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class papergenrater : MonoBehaviour
{
    IEnumerator timer()
    {
        yield return new WaitForSeconds(2);
        Instantiate(prefab, new Vector3(0.0f, 0.4f, -2.0f), Quaternion.identity);
    }
    public GameObject prefab;
    public void papergenerate()
    {
        StartCoroutine(timer());
    }
    
}
