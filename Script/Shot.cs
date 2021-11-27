using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField] private GameObject InsBullet;
    [SerializeField] private float speedInsBullet;
    [SerializeField] private AudioSource bulletMp;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) ShootLogic();
    }
    private void ShootLogic()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(InsBullet, transform.position, Quaternion.identity);
            Instantiate(bulletMp, transform.position, Quaternion.identity);
            bullet.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * speedInsBullet) ;
            Destroy(bullet.gameObject, 1.5f);
        }
    }
}
