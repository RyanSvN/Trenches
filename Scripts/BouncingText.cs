using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BouncingText : MonoBehaviour
{
    public float bobSpeed = 1f;
    public float bobHeight = 0.5f;
    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        //calculate the new Y position based on a sine wave
        float newY = originalPosition.y + Mathf.Sin(Time.time * bobSpeed) * bobHeight;

        //update the texts position
        transform.position = new Vector3(originalPosition.x, newY, originalPosition.z);
    }
}