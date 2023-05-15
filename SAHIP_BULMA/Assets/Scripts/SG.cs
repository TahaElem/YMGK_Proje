using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SG : MonoBehaviour
{
   
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

   


}
