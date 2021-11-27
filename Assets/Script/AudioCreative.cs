using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCreative : MonoBehaviour
{
   [SerializeField] private AudioSource audioShow;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Instantiate(audioShow, transform.position, Quaternion.identity); 
        }
    }
}
