using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class windowscript2 : MonoBehaviour
{
    [SerializeField] Button CloseBtn;
    // Start is called before the first frame update
    void Start()
    {
        CloseBtn.onClick.AddListener(() =>
        {
            gameObject.SetActive(false); //�|�۰ʧP�_gameObject�N�O�ثe�{��(component)�Ҧb��GameObject�����A�������wCloseBtn�A�_�h�N�|��CloseBtn�ۤv����
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
