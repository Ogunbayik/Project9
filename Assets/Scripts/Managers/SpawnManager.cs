using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instance;

    [HideInInspector]
    public GameObject[] boxes;
    [Header("Spawn Borders")]
    [Range(12,18)]
    [SerializeField] private float borderX;
    [Range(6,9)]
    [SerializeField] private float borderZ;
    [Header("Summon Settings")]
    [SerializeField] private float startSummon;
    [SerializeField] private float repeatSummon;

    private Vector3 randomRotationY;
    void Start()
    {

        InvokeRepeating(nameof(SpawnRandomBox), startSummon, repeatSummon);
    }
    private void Update()
    {
        if (GameManager.Instance.currentState != GameManager.GameStates.GameInGame)
            StopSpawning();
    }

    public void StopSpawning()
    {
        CancelInvoke(nameof(SpawnRandomBox));
    }

    #region RandomPosition
    Vector3 RandomPosition()
    {
        var randomX = Random.Range(-borderX, borderX);
        var randomZ = Random.Range(-borderZ, borderZ);

        Vector3 randomPosition = new Vector3(randomX, 0.7f, randomZ);
        return randomPosition;
    }
    #endregion


    #region SpawnBox
    void SpawnRandomBox()
    {
        var randomIndex = Random.Range(0, boxes.Length);
        var randomRotationY = Random.Range(225, 315);
        var randomRotation = new Vector3(0f, randomRotationY, 270f);
        Instantiate(boxes[randomIndex], RandomPosition(), Quaternion.Euler(randomRotation));
    }
    #endregion
}
