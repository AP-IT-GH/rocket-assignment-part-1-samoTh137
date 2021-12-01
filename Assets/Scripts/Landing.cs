using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Landing : MonoBehaviour
{
    public string LevelToLoad = "";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    [System.Obsolete]
    private void OnTriggerEnter(Collider other)
        {
        if (other.gameObject.tag == "Player")
            {
            print("Open Next Scene");

            Application.LoadLevel(LevelToLoad);
            }
        }
    }     
    

