using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour
{
    public Camera IntroCamera;
    public GameObject PlayerCamera;
    public GameObject screenRenderer;
    // Start is called before the first frame update
    public void FinishedIntro(){
         StartCoroutine(WaitingTime());
    }

    IEnumerator WaitingTime(){
        screenRenderer.GetComponent<Animator>().SetTrigger("End");
        yield return new WaitForSeconds(1);
        IntroCamera.gameObject.SetActive(false);
        PlayerCamera.SetActive(true);
    }
    public void EndGame(){
        print("End Game");
        SceneManager.LoadScene("scene adv 2");
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
