using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{ 
    public static int score = 100;
    [SerializeField] Button[] MainBUttons;
    [SerializeField] GameObject[] WindowGOs;
    // Start is called before the first frame update
    void Start()
    {
        //MainBUtton.onClick.AddListener(() =>
        //{
        // WindowGO.SetActive(true);
        //});
        for (int i = 0; i < WindowGOs.Length; i++)
        {
            int j = i;
            MainBUttons[j].onClick.AddListener(() =>
            {
                WindowGOs[j].SetActive(true);
            });
        }
    
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
