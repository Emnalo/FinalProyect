using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartScript : MonoBehaviour
{
    public GameObject screenRenderer;
    public GameObject button;
    public GameObject FinishText;
    public GameObject Fireworks;
    // Start is called before the first frame update
    public void GameRestarted(){
        StartCoroutine(Wait());   
    }

    public void StartFireworks(){
        Fireworks.SetActive(true);
    }
    IEnumerator Wait(){
        yield return new WaitForSeconds(2);
        screenRenderer.GetComponent<Animator>().SetTrigger("Restarting");
        Cursor.visible = true;
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
