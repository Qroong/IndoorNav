using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinpoint_Grab : MonoBehaviour
{

    [SerializeField]
    private GameObject player;


    private void OnTriggerStay(Collider other)
    {
        player.transform.position = transform.parent.position;
    }

}
