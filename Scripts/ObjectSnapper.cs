using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSnapper : MonoBehaviour
{
    public GameObject[] objectsToSnap;
    public Transform[] snapPositions;

    public bool allObjectsSnapped = false;

    public GameObject callText;

    void Update()
    {
        if (!allObjectsSnapped && CheckAllObjectsSnapped())
        {
            OnSnapped();
            allObjectsSnapped = true;
        }
    }

    private bool CheckAllObjectsSnapped()
    {
        //check if objects are in position
        for (int i = 0; i < objectsToSnap.Length; i++)
        {
            float distance = Vector3.Distance(objectsToSnap[i].transform.position, snapPositions[i].position);
            if (distance > 0.5f)
                return false;
        }
        return true;
    }

    public void OnSnapped()
    {
        Debug.Log("All objects snapped!");
        callText.SetActive(true);

    }
}
