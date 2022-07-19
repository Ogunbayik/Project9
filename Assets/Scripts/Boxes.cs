using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Boxes : MonoBehaviour, ICollectible
{
    public static event Action OnBoxCollected1;
    public static event Action OnBoxCollected2;
    public static event Action OnBoxCollected3;
    public static event Action OnBoxCollected4;
    public static event Action OnBoxCollected5;
    public static event Action OnBoxCollected6;
    public static event Action OnBoxCollected7;
    public static event Action OnBoxCollected8;
    public static event Action OnBoxCollected9;


    public void Collect()
    {
        if(gameObject.tag == "Box1")
        {
            Destroy(gameObject);
            OnBoxCollected1?.Invoke();
        }
        else if(gameObject.tag == "Box2")
        {
            Destroy(gameObject);
            OnBoxCollected2?.Invoke();
        }
        else if(gameObject.tag == "Box3")
        {
            Destroy(gameObject);
            OnBoxCollected3?.Invoke();
        }
        else if(gameObject.tag == "Box4")
        {
            Destroy(gameObject);
            OnBoxCollected4?.Invoke();
        }
        else if(gameObject.tag == "Box5")
        {
            Destroy(gameObject);
            OnBoxCollected5?.Invoke();
        }
        else if(gameObject.tag == "Box6")
        {
            Destroy(gameObject);
            OnBoxCollected6?.Invoke();
        }
        else if(gameObject.tag == "Box7")
        {
            Destroy(gameObject);
            OnBoxCollected7?.Invoke();
        }
        else if(gameObject.tag == "Box8")
        {
            Destroy(gameObject);
            OnBoxCollected8?.Invoke();
        }
        else if(gameObject.tag == "Box9")
        {
            Destroy(gameObject);
            OnBoxCollected9?.Invoke();
        }
      
    }
}
