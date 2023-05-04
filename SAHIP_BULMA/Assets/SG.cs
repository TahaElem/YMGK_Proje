using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SG : MonoBehaviour
{
    public GameObject panel_bilgi;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space ))
        {
            SceneManager.LoadScene(1);
        }
    }
    public void sahnegec() 
    {
        SceneManager.LoadScene(1);
       
    
    }
    public void cikis()
    {
        Application.Quit();
    }

    public void panel_gizle() {
        Time.timeScale = 1;//tüm hareketi durdur

        panel_bilgi.SetActive(false);
    }
    public void panel_goster()
    {
         Time.timeScale = 0;//tüm hareketi baslat
        
        panel_bilgi.SetActive(true);
    }


}
