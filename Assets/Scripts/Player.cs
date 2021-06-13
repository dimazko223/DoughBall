using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody _physic;
    
    private void Start()
    {
        _physic = GetComponent<Rigidbody>();
    }
    
}
