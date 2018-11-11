using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class dieFade : MonoBehaviour 
{
    public Animator animator;

    public string loadlevel;
    
    public float health = 100;

    public Image healthBar;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "projectile")
        {
            health -= 20;
        }

        if (col.gameObject.tag == "lastProjectile")
        {
            health -= 20;
        }

        if (health <= 0)
            {
                fadeToLevel(1);
            }

        healthBar.fillAmount = health / 100f;

    }

    public void fadeToLevel (int levelIndex)
    {
        animator.SetTrigger("fadeOut");
        StartCoroutine(LoadAfterDelay("skirmish1_die"));
    }


    IEnumerator LoadAfterDelay(string levelName)
    {
        yield return new WaitForSeconds(01); // wait 1 seconds
        SceneManager.LoadScene(levelName);
    }
}
