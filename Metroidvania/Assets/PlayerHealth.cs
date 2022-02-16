using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public float PHealth; // Player Health Variable
    [SerializeField] public float PMHealth; //Maximum player health
    
    void Start()
    {

    }
    public void DamageSystem(float DamageAmount)
    {
        PHealth -= DamageAmount;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PHealth < 1) { PHealth = 10.0f; } ; // Temporary Death State
        if (PHealth > PMHealth) { PHealth = PMHealth; }; // if players health goes above the maximum set it back to the maximum
    }

}
