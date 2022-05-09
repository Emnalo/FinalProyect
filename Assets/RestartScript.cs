using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartScript : MonoBehaviour
{
    public GameObject screenRenderer;
    public GameObject button;
    public Camera PlayerCamera;
    public GameObject FinishText;
    // Start is called before the first frame update
    public void GameRestarted(){
        StartCoroutine(Wait());   
    }
    IEnumerator Wait(){
        yield return new WaitForSeconds(2);
        screenRenderer.GetComponent<Animator>().SetTrigger("Restarting");
        PlayerCamera.gameObject.SetActive(false);
        FinishText.SetActive(true);
        button.SetActive(true);
        }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
