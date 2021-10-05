using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Click_Handler : MonoBehaviour
{
    public Button button;

    public GameObject onClickTurnOff;
    public GameObject onClickTurnOn;
  


    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(HandleClick);

    }

    void HandleClick()
    {
        onClickTurnOff.SetActive(false);
        onClickTurnOn.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
