using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class healthController : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public Sprite fullHealth;
    public Sprite emptyHealth;

    public Image[] hearts;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < hearts.Length; i++){
            if (i<currentHealth){
                hearts[i].sprite = fullHealth;
            }
            else{
                hearts[i].sprite = emptyHealth;
            }
        }
    }

    public void TakeDamage(){
        if (currentHealth > 0){
            currentHealth -= 1;
        }
    }

    public void Heal(){
        if (currentHealth < maxHealth){
            currentHealth += 1;
        }
    }
}
