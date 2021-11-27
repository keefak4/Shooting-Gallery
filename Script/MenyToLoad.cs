using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenyToLoad : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            Invoke("LoadScenePlay", 3f);
        }
    }
    private void LoadScenePlay()
    {
        SceneManager.LoadScene(1);
    }
}
