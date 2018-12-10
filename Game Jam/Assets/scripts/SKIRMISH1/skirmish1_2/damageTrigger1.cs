using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class damageTrigger1 : MonoBehaviour 
{
    public Animator animator;

    public string loadlevel;
    
    public float health = 100;

    public Image healthBar;

    public AudioSource hitmarker;

    void Start()
    {
        hitmarker = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "projectile")
        {
            health -= 20;
            hitmarker.Play();
        }
        if (col.gameObject.tag == "projectile1")
        {
            health -= 20;
            hitmarker.Play();
        }
        if (col.gameObject.tag == "projectile2")
        {
            health -= 20;
            hitmarker.Play();
        }
        if (col.gameObject.tag == "projectile3")
        {
            health -= 20;
            hitmarker.Play();
        }
        if (col.gameObject.tag == "projectile4")
        {
            health -= 20;
            hitmarker.Play();
        }
        if (col.gameObject.tag == "projectile5")
        {
            health -= 20;
            hitmarker.Play();
        }
        if (col.gameObject.tag == "projectile6")
        {
            health -= 20;
            hitmarker.Play();
        }
        if (col.gameObject.tag == "projectile7")
        {
            health -= 20;
            hitmarker.Play();
        }
        if (col.gameObject.tag == "projectile8")
        {
            health -= 20;
            hitmarker.Play();
        }
        if (col.gameObject.tag == "lastProjectile")
        {
            health -= 20;
            hitmarker.Play();
        }

        if (health <= 0)
            {
                //fadeToLevel(1);
                SceneManager.LoadScene("skirmish1_die");
            }

        healthBar.fillAmount = health / 100f;

    }

    //public void fadeToLevel (int levelIndex)
    //{
    //    animator.SetTrigger("fadeOut");
    //    StartCoroutine(LoadAfterDelay("skirmish1_die"));
    //}


    //IEnumerator LoadAfterDelay(string levelName)
    //{
    //    yield return new WaitForSeconds(01); // wait 1 seconds
    //    SceneManager.LoadScene(levelName);
    //}
}
