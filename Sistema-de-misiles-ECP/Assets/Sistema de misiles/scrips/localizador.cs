using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class localizador : MonoBehaviour
{

    public TMP_Text positionMisilText;
    public GameObject Misil;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        positionMisilText.text = "posicion del misil: " + Misil.transform.position.ToString(); 
    }
}
