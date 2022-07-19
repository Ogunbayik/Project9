using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxesDead : MonoBehaviour
{
    [SerializeField] private float deadTime;

    void Update()
    {
        if(gameObject != null)
        {
            Destroy(gameObject, deadTime);
        }
    }
}
