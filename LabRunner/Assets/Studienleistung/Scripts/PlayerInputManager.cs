﻿using UnityEngine;
using System.Collections;

public class PlayerInputManager : MonoBehaviour {

    
    private string m_inputMovementAxisName;
    private string m_inputRotationAxisName;

    private float m_inputMovement;
    private float m_inputRotation;

    private Rigidbody m_rigidbody;

    public float m_rotationSpeed;
    public float rotationSpeed
    {
        get {   return m_rotationSpeed;     }
        set {   m_rotationSpeed = value;    }
    }

    public float m_speedBoost;
    public float speedBoost
    {
        get {   return m_speedBoost;    }
        set {   m_speedBoost = value;   }
    }

    private void Move()
    {
        m_inputMovement = Input.GetAxis(m_inputMovementAxisName);
        Vector3 movement = transform.forward * m_speedBoost * m_inputMovement * Time.deltaTime;
        m_rigidbody.MovePosition(m_rigidbody.position + movement);
    }

    private void Rotate()
    {
        m_inputRotation = Input.GetAxis(m_inputRotationAxisName);

        float turn = m_inputRotation * m_rotationSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        m_rigidbody.MoveRotation(m_rigidbody.rotation * turnRotation);

    }
    void FixedUpdate()
    {
        Move();
        Rotate();
    }

	public void Init() {
        m_inputMovementAxisName = "Vertical";
        m_inputRotationAxisName = "Horizontal";
        
        m_rotationSpeed = 180;
        m_speedBoost = 5;

        m_rigidbody = GetComponent<Rigidbody>();
	}
	
}
