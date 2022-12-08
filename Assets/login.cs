using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class login : MonoBehaviour
{
    public Button usrelogin;
    public TMP_InputField UserName;
    public TMP_InputField PassWord;
    public TMP_Text Mistake;
    public TMP_Text Register;

    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButton()
 {
    string UserNam = UserName.text;
    string PassWor = PassWord.text;
    if(UserNam == "ntnu" && PassWor == "123")
    {
        Register.gameObject.SetActive(true);
        StartCoroutine(Disappear());
        SceneManager.LoadScene("mainsign");
    }
    else
    {
        Mistake.gameObject.SetActive(true);
        StartCoroutine(Disappear());
    }
 }
 IEnumerator Disappear()
 {
    yield return new WaitForSeconds(2);
    Mistake.gameObject.SetActive(false);
    Register.gameObject.SetActive(false);
 }
 }


