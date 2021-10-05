using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSelect : MonoBehaviour
{

    public GameObject plant1;
    public GameObject plant2;
    public GameObject plant3;
    public GameObject plant4;
    public GameObject plant5;
    public GameObject plant6;
    public GameObject plant7;
    public GameObject plant8;
    public GameObject plant9;


    public GameObject plant1btn;
    public GameObject plant2btn;
    public GameObject plant3btn;
    public GameObject plant4btn;
    public GameObject plant5btn;
    public GameObject plant6btn;
    public GameObject plant7btn;
    public GameObject plant8btn;
    public GameObject plant9btn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void plant1Clicked()
    {
        plant1.SetActive(true);
        plant2.SetActive(false);
        plant3.SetActive(false);
        plant4.SetActive(false);
        plant5.SetActive(false);
        plant6.SetActive(false);
        plant7.SetActive(false);
        plant8.SetActive(false);
        plant9.SetActive(false);
  
    }

    public void plant2Clicked()
    {
        plant1.SetActive(false);
        plant2.SetActive(true);
        plant3.SetActive(false);
        plant4.SetActive(false);
        plant5.SetActive(false);
        plant6.SetActive(false);
        plant7.SetActive(false);
        plant8.SetActive(false);
        plant9.SetActive(false);
    }


    public void plant3Clicked()
    {
        plant1.SetActive(false);
        plant2.SetActive(false);
        plant3.SetActive(true);
        plant4.SetActive(false);
        plant5.SetActive(false);
        plant6.SetActive(false);
        plant7.SetActive(false);
        plant8.SetActive(false);
        plant9.SetActive(false);
    }

    public void plant4Clicked()
    {
        plant1.SetActive(false);
        plant2.SetActive(false);
        plant3.SetActive(false);
        plant4.SetActive(true);
        plant5.SetActive(false);
        plant6.SetActive(false);
        plant7.SetActive(false);
        plant8.SetActive(false);
        plant9.SetActive(false);
    }

    public void plant5Clicked()
    {
        plant1.SetActive(false);
        plant2.SetActive(false);
        plant3.SetActive(false);
        plant4.SetActive(false);
        plant5.SetActive(true);
        plant6.SetActive(false);
        plant7.SetActive(false);
        plant8.SetActive(false);
        plant9.SetActive(false);
    }

    public void plant6Clicked()
    {
        plant1.SetActive(false);
        plant2.SetActive(false);
        plant3.SetActive(false);
        plant4.SetActive(false);
        plant5.SetActive(false);
        plant6.SetActive(true);
        plant7.SetActive(false);
        plant8.SetActive(false);
        plant9.SetActive(false);
    }

    public void plant7Clicked()
    {
        plant1.SetActive(false);
        plant2.SetActive(false);
        plant3.SetActive(false);
        plant4.SetActive(false);
        plant5.SetActive(false);
        plant6.SetActive(false);
        plant7.SetActive(true);
        plant8.SetActive(false);
        plant9.SetActive(false);
    }
    public void plant8Clicked()
    {
        plant1.SetActive(false);
        plant2.SetActive(false);
        plant3.SetActive(false);
        plant4.SetActive(false);
        plant5.SetActive(false);
        plant6.SetActive(false);
        plant7.SetActive(false);
        plant8.SetActive(true);
        plant9.SetActive(false);
    }
    public void plant9Clicked()
    {
        plant1.SetActive(false);
        plant2.SetActive(false);
        plant3.SetActive(false);
        plant4.SetActive(false);
        plant5.SetActive(false);
        plant6.SetActive(false);
        plant7.SetActive(false);
        plant8.SetActive(false);
        plant9.SetActive(true);
    }

}
