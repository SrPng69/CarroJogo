using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gasolina : MonoBehaviour
{
    public Image Disel;

    // Start is called before the first frame update
    void Update()
    {
        Disel.fillAmount -= Input.GetAxis("Horizontal") / 870f;
    }

    public void AddFuel()
    {
        Disel.fillAmount += 0.29f;
    }
}
