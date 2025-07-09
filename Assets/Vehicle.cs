using System;
using TMPro;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    protected Rigidbody _rigidBody;
    [SerializeField] private float speed;
    [SerializeField] protected TextMeshPro busName;

    private void Start() {
        _rigidBody = GetComponent<Rigidbody>();
    }

    protected virtual void Move() {
        _rigidBody.AddForce(transform.forward * (speed * Time.deltaTime));
    }

    protected virtual void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Move();
        }
    }
}
