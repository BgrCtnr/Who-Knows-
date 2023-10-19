using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer1 : MonoBehaviour
{
    [SerializeField] private Image _time;
    [SerializeField] private Text _timeText;
    [SerializeField] private float _currentTime;
    [SerializeField] private float _duration;

    public GameObject secenekdosya, replay, dybutton;
    public Text buttontimer123 ;
        
    void Start()
    {
        _currentTime = _duration;
        _timeText.text = _currentTime.ToString();
        StartCoroutine(CountdownTime());
    }

    private IEnumerator CountdownTime () {
        while(_currentTime >= 0) {
            _time.fillAmount = Mathf.InverseLerp(0, _duration, _currentTime);
            _timeText.text = _currentTime.ToString();
            yield return new WaitForSeconds(1f);
            _currentTime--;
        }
        yield return null;
        
             if(_currentTime <=0){
        
        replay.SetActive(true);
            replay.GetComponent<Image>().color = new Color(255, 0,0);


        buttontimer123.text = "Tekrar Oyna! ";

        buttontimer123= gameObject.GetComponent<Text>();
        

        }
        
    }
public void ResetTimer()
{
    // Aktif olan tüm geri sayımları durdurun.
    _currentTime = _duration; // Zamanı başlangıç değerine sıfırlayın.
    _timeText.text = _currentTime.ToString(); // Metni güncelleyin.
    _time.fillAmount = 1f; // İleri sayım çubuğunu tamamen doldurun (100%).
}



    
    public void ResetTimerOnClick()
{
    ResetTimer(); // Zamanlayıcıyı sıfırla.
    // Ekstra işlemleri burada ekleyebilirsiniz, örneğin düğmenin görünürlüğünü değiştirebilirsiniz.
}



    public void replaypred(){

             if(_currentTime<=0){
        
            
            SceneManager.LoadScene("Anaekran");
    
        }

    }



}
