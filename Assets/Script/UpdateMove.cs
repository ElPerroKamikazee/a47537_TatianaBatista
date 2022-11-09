using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMove : MonoBehaviour
{
    public float Speed = (2.0f);

    void Update()
    {
        this.transform.Translate(0, 0, Time.deltaTime * Speed);
    }
}
