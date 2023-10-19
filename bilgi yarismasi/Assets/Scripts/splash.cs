using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splashsc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Countdown");


    }

            private IEnumerator Countdown() 
            {
                
                yield return new WaitForSeconds(3);
                SceneManager.LoadScene("anaekran");
            }

    void Update()
    {
        
    }
}
