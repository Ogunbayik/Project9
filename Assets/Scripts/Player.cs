using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector]
    public CharacterController controller;
    [Header("Player Settings")]
    [SerializeField] private float speed;
    [Header("Map Borders")]
    [Range(15,19)]
    [SerializeField]private float borderX = 19f;
    [Range(8,10.5f)]
    [SerializeField]private float borderZ = 10.5f;

    private float horizontalInput;
    private float verticalInput;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (GameManager.Instance.currentState == GameManager.GameStates.GameInGame)
        {
            Movement();
            BorderInMap();
        }
    }

    #region Movement
    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime;
        verticalInput = Input.GetAxis("Vertical") * Time.deltaTime;

        var movement = new Vector3(horizontalInput, 0f, verticalInput) * speed;
        controller.Move(movement);
    }
    #endregion


    #region Borders
    void BorderInMap()
    {
        if(gameObject.transform.position.x > borderX)
        {
            transform.position = new Vector3(borderX, transform.position.y, transform.position.z);
        }
        else if(gameObject.transform.position.x < -borderX)
        {
            transform.position = new Vector3(-borderX, transform.position.y, transform.position.z);
        }
        else if(gameObject.transform.position.z > borderZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, borderZ);
        }
        else if(gameObject.transform.position.z < -borderZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -borderZ);
        }
    }
    #endregion
}
