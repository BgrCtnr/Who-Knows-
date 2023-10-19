using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class slider : MonoBehaviour
{

    private Text info;
    private float sayac;
    private Slider zaman;

    public GameObject secenekdosya, replay, dybutton, soruarkaplan, canvastimer, ödülekrani, cikis123;
    public Text buttontimer123 ;
        

private void Awake()
{
        info = GameObject.FindWithTag("info").GetComponent<Text>();
        zaman = GameObject.Find("Timer").GetComponent<Slider>();

}








void Start()
{

    zaman.maxValue = 21;
    zaman.minValue = 0;
    zaman.wholeNumbers = false ;
    zaman.value = zaman.maxValue;
    sayac = zaman.value;

}

   






void Update()
{

    if(zaman.maxValue > zaman.minValue)
    {

    sayac -= Time.deltaTime;
    zaman.value = sayac;
    info.text = ((int)zaman.value).ToString();

    }


    else
    {

    info.text = "Zaman Doldu";

    }



if(zaman.value <=0)
{
        
replay.SetActive(true);
replay.GetComponent<Image>().color = new Color(255, 0,0);


buttontimer123.text = "Zaman Doldu, Tekrar Oyna! ";

buttontimer123=gameObject.GetComponent<Text>();

        secenekdosya.SetActive(false);
        soruarkaplan.SetActive(false);
        canvastimer.SetActive(false);
        ödülekrani.SetActive(false);
        cikis123.SetActive(false);
        

}

}
        



public void ResetTimer()
{
    sayac = zaman.maxValue;
    zaman.value = sayac;
    info.text = ((int)zaman.value).ToString();
}





    public void replaypress()
    {

    SceneManager.LoadScene("Anaekran");

    }
         



}





