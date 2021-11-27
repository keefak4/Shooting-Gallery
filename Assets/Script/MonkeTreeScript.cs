using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeTreeScript : MonoBehaviour
{
    [SerializeField] private GameObject monkeGameObgect;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            GameObject monke = Instantiate(monkeGameObgect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
