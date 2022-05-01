using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossFade : MonoBehaviour
{
    public GameObject renderScreen;
    // Start is called before the first frame update
    public void startCrossfade(){
        renderScreen.GetComponent<Animator>().SetBool("Fade",false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
