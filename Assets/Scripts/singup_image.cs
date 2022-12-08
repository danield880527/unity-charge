using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class singup_image : MonoBehaviour
{
   public Button singup;
   public GameObject window5;
    // Start is called before the first frame update
    void Start()
    {
         singup.onClick.AddListener(() =>
        {
            print("100");
           window5.SetActive(true);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
