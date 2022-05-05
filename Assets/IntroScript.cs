using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class IntroScript : MonoBehaviour
{
    public Camera IntroCamera;
    public Camera PlayerCamera;
    public GameObject screenRenderer;
    // Start is called before the first frame update
    public void FinishedIntro(){
         StartCoroutine(WaitingTime());
    }

    IEnumerator WaitingTime(){
        screenRenderer.GetComponent<Animator>().SetTrigger("End");
        yield return new WaitForSeconds(1);
        IntroCamera.gameObject.SetActive(false);
        PlayerCamera.gameObject.SetActive(true);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
