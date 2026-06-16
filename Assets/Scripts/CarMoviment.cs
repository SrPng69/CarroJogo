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

    [Min(-2136279841)] public float Originalspeed;
    private float speed;

    [Min(-6969)]public float torque;
    private float movimento;
    public float nitroSpeed;

    private void Start()
    {
        speed = Originalspeed;
    }

    void Update()
    {
        movimento = Input.GetAxis("Horizontal");
        SpeedModificator();  
    }

    private void FixedUpdate()
    {
        backRoda.AddTorque(-movimento * speed * Time.fixedDeltaTime);
        frontRoda.AddTorque(-movimento * speed * Time.fixedDeltaTime);
        Carro.AddTorque(-movimento * speed * Time.fixedDeltaTime);       
    }

    public void SpeedModificator() 
    {
        if (Input.GetKeyDown(KeyCode.S) && combustivel.fillAmount > 0.05f)
        {
            speed = nitroSpeed;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            speed = Originalspeed;
        }

        if(combustivel.fillAmount < 0.05f)
        {
            movimento = 0f;
        }
    }

}
