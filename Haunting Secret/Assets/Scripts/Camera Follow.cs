using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    public float minX, maxX;
    public float timeLerp;
    private void FixedUpdate()
    {
        GameObject player = GameObject.FindWithTag("Player");
        Vector3 newPosition = player.transform.position + new Vector3(0, 0, -10);
        newPosition.y = 0.1f;
        transform.position = Vector3.Lerp(transform.position, newPosition, timeLerp);
        transform.position = newPosition;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,minX,maxX), transform.position.y, transform.position.z);

        
    }
}