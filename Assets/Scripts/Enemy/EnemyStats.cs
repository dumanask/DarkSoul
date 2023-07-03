using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ED
{
    public class EnemyStats : MonoBehaviour
    {
        public int healthLevel = 10;
        public int maxHealth;
        public int currentHealth;

        //public HealthBar healthBar;

        Animator animator;

        private void Awake()
        {
            animator = GetComponentInChildren<Animator>();

        }
        void Start()
        {
            maxHealth = SetMaxHealthFromHealthLevel();
            currentHealth = maxHealth;
           // healthBar.SetMaxHealth(maxHealth);
        }

        private int SetMaxHealthFromHealthLevel()
        {
            maxHealth = healthLevel * 10;
            return maxHealth;
        }

        public void TakeDamage(int damage)
        {
            currentHealth = currentHealth - damage;

           // healthBar.SetCurrentHealth(currentHealth);

            //animator.Play("Damage_01");

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                //animator.Play("Dead_01");
            }
        }

    }
}