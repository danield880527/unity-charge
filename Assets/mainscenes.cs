using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class mainscenes : MonoBehaviour
{
    public FirebaseManager firebaseManager;
    public TMP_InputField inputEmail;
    public TMP_InputField inputPassword;
    public GameObject windowlogin;
    public GameObject windowloginsuccess;
    public TMP_InputField carenumber;


   

    // Start is called before the first frame update
    void Start()
    {
        firebaseManager.auth.StateChanged += AuthStateChanged;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
          firebaseManager.SaveData(carenumber.text);
        }
    }

    public void SaveCarenumver()
    {
      firebaseManager.SaveData(carenumber.text);
    }





    public void Register()
    {
        firebaseManager.Register(inputEmail.text, inputPassword.text);
    }

     public void Login()
    {
        firebaseManager.Login(inputEmail.text, inputPassword.text);
    }

     public void Logout()
    {
        firebaseManager.Logout();
        
    }
    

     void AuthStateChanged(object sender, System.EventArgs eventArgs)
     {
         if(firebaseManager.user != null)
        {
          print("loginsuccess");
        }
        if(firebaseManager.user == null)
        {
          print("logoutsuccess");
        }
     }

    void OnDestroy()
    {
        firebaseManager.auth.StateChanged -= AuthStateChanged;
    }
    
}

