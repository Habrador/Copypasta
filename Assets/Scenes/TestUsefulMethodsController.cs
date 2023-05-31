using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Copypasta;

public class TestUsefulMethodsController : MonoBehaviour
{
    public Transform parentTransform;


    private void Start()
    {
        UsefulMethods.DestroyAllChildren(parentTransform);
    }
}
