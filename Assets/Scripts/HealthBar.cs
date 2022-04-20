using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] public Text healthText;

    private void Start()
    {
        this.healthText.text = "Health: 100%";
    }

    private void Update()
    {
        Health targetHealth = this.gameObject.GetComponent<Health>();
        this.healthText.text = "Health: " + targetHealth.HealthValue + "%";
    }
}
