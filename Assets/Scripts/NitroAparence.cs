using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class NitroAparence : MonoBehaviour
{
    public GameObject fogoNitro;
    public Image combustivel;

    void Update()
    {
        Fogologic();     
    }

    void Fogologic()
    {
      if (Input.GetKeyDown(KeyCode.S) /*&& combustivel.fillAmount > 0.05f*/)
        {
            fogoNitro.SetActive(true);        
        }
      if (Input.GetKeyUp(KeyCode.S))
        {
            fogoNitro.SetActive(false);
        }
    }

}
