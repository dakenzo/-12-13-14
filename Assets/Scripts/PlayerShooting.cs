using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);
    public GameObject bulletrefab;
    public float fireDelay = 0.25f;
    int bulletLayer;
    float cooldownTimer = 0;
    
    void Start()
    {
        bulletLayer = gameObject.layer;
    }
    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        if(Input.GetButton("Fire1") && cooldownTimer<=0)//shoot!
        {
            Debug.Log("Pew!");
            cooldownTimer = fireDelay;
            Vector3 offset = transform.rotation* bulletOffset;
            GameObject bulletGO = (GameObject)Instantiate(bulletrefab, transform.position + offset, transform.rotation);
            bulletGO.layer = bulletLayer;
        }
    }
}
