using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tasi : MonoBehaviour
{
    Camera kamera;
    Vector2 baslangic_pos;
    GameObject[] kutu_dizisi;
    Yonetim yonet;


    private void OnMouseDrag() 
    {
        Vector3 pozisyon = kamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;
    
    }
    void Start()
    {
        kamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        baslangic_pos = transform.position;
        kutu_dizisi = GameObject.FindGameObjectsWithTag("kutu");
        yonet = GameObject.Find("yonetim").GetComponent<Yonetim>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonUp(0))
        {
            foreach (GameObject kutu in kutu_dizisi)
            {

                if (kutu.name==gameObject.name)
                {

                    float mesafe = Vector3.Distance(kutu.transform.position, transform.position);
                    if (mesafe<=1)
                    {
                        transform.position = kutu.transform.position;
                        yonet.sayi_artir();
                        this.enabled = false;

                    }
                    else if(mesafe>1)
                    {
                        transform.position = baslangic_pos;
                        yonet.Can_kontrol();//düzenle
                    }

                }
            }

        }
        
    }
}
