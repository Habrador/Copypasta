using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Copypasta;

public class TestUsefulMethodsController : MonoBehaviour
{
    public Transform parentTransform;


    private void Start()
    {
        GameObject[] allChildren = UsefulMethods.GetAllChildren(parentTransform);

        foreach (GameObject c in allChildren)
        {
            Destroy(c);
        }
    }
}
