using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CollisionHandler : MonoBehaviour {

    [Tooltip("Level load delay in seconds")][SerializeField] float levelLoadDelay =1f;
    [Tooltip("FX prefab on player")][SerializeField] GameObject deathFX;



    private void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
    }

    private void StartDeathSequence()
    {
        deathFX.SetActive(true);
        print("Player Died");
        Invoke("ReloadLevel", 1f);
        //SendMessage("OnPlayerDeath");
        
    }

    private void ReloadLevel()
    {
        SceneManager.LoadScene(1);
    }
}
