using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
           if (Input.GetKeyDown("space"))
        {
           DamageEarth(10);
        }
    }

    private void OnTriggerEnter(Collider other){
        if (other.tag == "asteroid"){
            DamageEarth(10);
        }
      
    }

    public void DamageEarth(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            // Can replace this with an animation call and 
            // ienumerator to change the scene after the
            // a timer is up
            SceneManager.LoadScene("GameOver");
        }
    }
}
