using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SplashManager : MonoBehaviour {

    // Use this for initialization

    private void Awake()
    {
        GameObject.DontDestroyOnLoad(gameObject);
    }

}
