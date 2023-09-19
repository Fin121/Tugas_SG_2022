using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject PlayerBullet;
    public GameObject BulletPos;
    public float speed;
    public AudioClip Fire;
    AudioSource audio1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            audio1 = GetComponent<AudioSource>();
            audio1.clip = Fire;
            audio1.Play();
            GameObject bullet = (GameObject)Instantiate (PlayerBullet);
            bullet.transform.position = BulletPos.transform.position;
        }
        
        float horizontal = Input.GetAxis ("Horizontal"); 
        if (horizontal != 0f)
        if (horizontal > 0f)
             transform.Translate (5f * Time.deltaTime, 0f, 0f);
         else
            transform.Translate (-5f * Time.deltaTime, 0f, 0f);
 
        float vertical = Input.GetAxis ("Vertical"); 
        if (vertical != 0f)
        if (vertical > 0f)
            transform.Translate (0f, 5f * Time.deltaTime, 0f);
        else
            transform.Translate (0f, -5f * Time.deltaTime, 0f);

            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.20f, 8.20f),
            Mathf.Clamp(transform.position.y, -4.30f, 4.30f), transform.position.z);
    }

}
