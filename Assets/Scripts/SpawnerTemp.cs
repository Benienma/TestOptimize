using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTemp : MonoBehaviour
{
    public int numberOfBot = 1000;

    public int numberOfUnitPerLine = 100;

    public GameObject botGameObject;

    public Transform botHolder;

    private void Start()
    {
        for (var i = 0; i < numberOfBot; i++)
        {
            Instantiate(botGameObject, new Vector3((i / numberOfUnitPerLine) * 4, 0, 2 * ( i - (i / numberOfUnitPerLine) * numberOfUnitPerLine)), Quaternion.identity, botHolder);
        }

        botHolder.transform.position = new Vector3(0, 0, -500);
    }
}
