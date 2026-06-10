using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarMoviment : MonoBehaviour
{
    public Rigidbody2D Carro;
    public Rigidbody2D frontRoda;
    public Rigidbody2D backRoda;
    public Image combustivel;

    [Min(-2136279841)] public float speed;
    [Min(-6969)]public float torque;
    private float movimento;

    void Update()
    {
        movimento = Input.GetAxis("Horizontal");
        
        if(combustivel.fillAmount < 0.05f)
        {
            movimento = 0f;
        }
    }

    private void FixedUpdate()
    {
        backRoda.AddTorque(-movimento * speed * Time.fixedDeltaTime);
        frontRoda.AddTorque(-movimento * speed * Time.fixedDeltaTime);
        Carro.AddTorque(-movimento * speed * Time.fixedDeltaTime);

       
    }
}
