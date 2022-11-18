using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TGTEST : MonoBehaviour
{
    [SerializeField]
    private GameObject toggleObject;

    public void Toggle()
    {
        toggleObject.SetActive(!toggleObject.activeSelf);
    }
}
