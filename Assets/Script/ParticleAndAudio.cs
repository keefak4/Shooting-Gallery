using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleAndAudio : MonoBehaviour
{
   [SerializeField] private ParticleSystem chikenBoom;
    [SerializeField] private AudioSource chikenSpurce;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Instantiate(chikenBoom, transform.position, Quaternion.identity);
            Instantiate(chikenSpurce, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
        }
    }
}
