using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    [SerializeField]
    private AudioSource yerlestirmeSes, kaybetmeSes, kazanmaSes, clickSes, bilgiSes, puanSes,zamankritikSes, yahooSes;

    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
    }

    #region ses methodlarý

    public void yahooses()
    {
        
        zamankritikSes.Stop();
        puanSes.Stop();
        bilgiSes.Stop();
        clickSes.Stop();
        yerlestirmeSes.Stop();
        kaybetmeSes.Stop();
        kazanmaSes.Stop();
        yahooSes.Play();

    }
    public void zamankritikses()
    {
        yahooSes.Stop();        
        puanSes.Stop();
        bilgiSes.Stop();
        clickSes.Stop();
        yerlestirmeSes.Stop();
        kaybetmeSes.Stop();
        kazanmaSes.Stop();
        zamankritikSes.Play();

    }
    public void puanses()
    {
        
        puanSes.Play();

    }
    public void bilgises()
    {
        yahooSes.Stop();
        zamankritikSes.Stop();
        puanSes.Stop();
        clickSes.Stop();
        yerlestirmeSes.Stop();
        kaybetmeSes.Stop();
        kazanmaSes.Stop();

        bilgiSes.Play();

    }
    public void clickses() {
        yahooSes.Stop();
        zamankritikSes.Stop();
        puanSes.Stop();
        bilgiSes.Stop();
        yerlestirmeSes.Stop();
        kaybetmeSes.Stop();
        kazanmaSes.Stop();
        clickSes.Play();
    
    }
    public void yerlestirmeses()
    {
        yahooSes.Stop();
        zamankritikSes.Stop();
        puanSes.Stop();
        bilgiSes.Stop();
        clickSes.Stop();
        kaybetmeSes.Stop();
        kazanmaSes.Stop();

        yerlestirmeSes.Play();

    }

    public void kaybetmeses()
    {
        yahooSes.Stop();
        zamankritikSes.Stop();
        puanSes.Stop();
        bilgiSes.Stop();
        clickSes.Stop();
        yerlestirmeSes.Stop();
        kazanmaSes.Stop();

        kaybetmeSes.Play();

    }
    public void kazanmases()
    {
        yahooSes.Stop();
        zamankritikSes.Stop();
        puanSes.Stop();
        bilgiSes.Stop();
        clickSes.Stop();
        yerlestirmeSes.Stop();
        kaybetmeSes.Stop();
        

        kazanmaSes.Play();

    }

   

    #endregion ses methodlarý

}
