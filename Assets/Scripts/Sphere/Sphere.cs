using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public GameObject spherePrefab;

    public void CreateSphere()
    {
        var a = Instantiate(spherePrefab);
        a.transform.position = Vector3.zero;
    }
}
