using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxMovement : MonoBehaviour
{
    [SerializeField] private float _paralexSpeed;
    void Update()
    {
        float xPosition = transform.position.x;
        if(xPosition > ParalaxManager.Instance.GetParalaxPivot().position.x * 2)
        {
            transform.position = new Vector3(xPosition - _paralexSpeed * ParalaxManager.Instance.GetSpeedMultiplier() * Time.deltaTime,
                transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x + (4.25f * 2),
                transform.position.y, transform.position.z);
        }
        
    }
}
