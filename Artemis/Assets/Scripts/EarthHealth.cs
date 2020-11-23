using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.setMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.setHealth(currentHealth);
    }

    private void OnTriggerEnter(Collider other){
        if (other.tag == "asteroid"){
            currentHealth -= 10;
        }
    }
}
