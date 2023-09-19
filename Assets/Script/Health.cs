using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public AudioClip Death;
    AudioSource audio2;
    public int mh = 100;
    public int ch;
    public Slide slide;
    [SerializeField]
    GameObject Gameover;

    // Start is called before the first frame update
    void Start()
    {
        ch = mh;
        slide.SetMaxHealth(mh);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "EnemyBullet")
        {
            TakeDamage(25);
            audio2 = GetComponent<AudioSource>();
            audio2.clip = Death;
            audio2.Play();
        }
    }

    void TakeDamage(int damage)
    {
        ch -= damage;
        slide.SetHealth(ch);
        if( ch == 0)
        {
            Time.timeScale = 0f;
            Gameover.SetActive(true);
            Debug.Log("Modar");
        }
    }

}
