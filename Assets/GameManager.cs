using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{ 
    [SerializeField] Button[] MainBUttons;
    [SerializeField] GameObject[] WindowGOs;
    [SerializeField] FirebaseManager fm;
    [SerializeField] GameObject windowlogin;
    [SerializeField] GameObject  windowloginsuccess;
    [SerializeField] Button button4;
    

    // Start is called before the first frame update
   void Start()
    {
       fm.auth.StateChanged += AuthStateChanged;
    }
    
    // Update is called once per frame
     void Update()
        {

        }
    


    void AuthStateChanged(object sender, System.EventArgs eventArgs)
    {
      
           
            if(fm.user == null)
            {
                 print("userisnull");
                windowloginsuccess.SetActive(false);
                windowlogin.SetActive(true);
                button4.onClick.AddListener(() =>
               {
                if(fm.user == null)
                  {
                    windowlogin.SetActive(true);
                  }
               });
                
            }

            if(fm.user != null)
            {
               print("usernotnull");
               windowlogin.SetActive(false);
              for (int i = 0; i < WindowGOs.Length; i++)
              {
                 int j = i;
                 MainBUttons[j].onClick.AddListener(() =>
                 {
                    if(fm.user != null)
                   {
                     WindowGOs[j].SetActive(true);
                   }

                 });

              }
             
            }
    }
        
    void OnDestroy()
    {
        print("ondestroy");
        fm.auth.StateChanged -= AuthStateChanged;
    }
    
}
