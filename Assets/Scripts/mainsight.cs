using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class mainsight : MonoBehaviour
{
    [SerializeField] FirebaseManager firebaseManager;
    public Button  Registerbutton;
    public TMP_InputField inputEmail;
    public TMP_InputField inputPassword;
    public TMP_Text Mistake;
    public TMP_Text RegisterSuccess;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Register(){
        print("110000");
        firebaseManager.Register(inputEmail.text, inputPassword.text);
    }
}
