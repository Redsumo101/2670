using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Ammo : MonoBehaviour
{
    public Text uiAmmo;
    public PlayerShooting shoot;

    void Start()
    {
        shoot = GetComponent<PlayerShooting>();
    }

    private void Update()
    {
        if (uiAmmo != null)
        {
            uiAmmo.text = shoot.currentAmmo.ToString();
        }
    }
}
