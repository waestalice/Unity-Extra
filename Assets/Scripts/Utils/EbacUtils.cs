using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using DG.Tweening;

public static class EbacUtils
{
#if UNITY_EDITOR
    [UnityEditor.MenuItem("Ebac/Create %g")]

    public static void Create()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.name = "Sphere";
        Debug.Log("Sphere created");
    }
#endif

    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }
}
