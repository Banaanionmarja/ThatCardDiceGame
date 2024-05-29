using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{

    public Text Maa;
    public Text Numero;

    public GameObject UI;

    // Start is called before the first frame update
    void Start()
    {
        Maa.text = "guh";
    }

    // Update is called once per frame
    void Update()
    {
        Maa.text = "buh";
    }


}
