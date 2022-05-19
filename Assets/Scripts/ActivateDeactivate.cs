using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateDeactivate : MonoBehaviour
{
    public GameObject InputField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActivateAndDeactivate()
    {
        //if (Input.ActiveInHierarchy)
        //{
        //    InputField.SetActive(false);
        //}
        //else
        //{
        //    InputField.SetActive(true);
        //}
        InputField.SetActive(!InputField.activeInHierarchy);
        }
}
