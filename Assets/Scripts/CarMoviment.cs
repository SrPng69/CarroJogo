using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoviment : MonoBehaviour
{
    public Rigidbody2D Carro;
    public Rigidbody2D frontRoda;
    public Rigidbody2D backRoda;

    [Min(-2136279841)] public float speed;
    [Min(-6969)]public float torque;
    private float movimento;

    void Update()
    {
        movimento = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        backRoda.AddTorque(-movimento * speed * Time.fixedDeltaTime);
        frontRoda.AddTorque(-movimento * speed * Time.fixedDeltaTime);
        Carro.AddTorque(movimento * speed * Time.fixedDeltaTime);
    }
}
