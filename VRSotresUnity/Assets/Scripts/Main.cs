using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public bool is8K = true;

    public GameObject panorama8K;
    public GameObject panorama16K;

    public TextMeshProUGUI changePanoramaText;
    public Button changePanoramaButton;

    private void Awake()
    {
        panorama8K.SetActive(true);
        panorama16K.SetActive(false);
        changePanoramaText.text = "Switch to 16K";
        changePanoramaButton.onClick.AddListener(() =>
        {
            if(is8K)
            {
                panorama16K.SetActive(true);
                panorama8K.SetActive(false);
                is8K = false;
                changePanoramaText.text = "Switch to 8K";
            }
            else
            {
                panorama16K.SetActive(false);
                panorama8K.SetActive(true);
                is8K = true;
                changePanoramaText.text = "Switch to 16K";
            }
        });
    }

    
}
