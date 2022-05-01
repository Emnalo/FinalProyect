using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationFinisher : MonoBehaviour
{
    public GameObject renderScreen;
    public void CrossFade(){
        renderScreen.GetComponent<Animator>().SetBool("Fade",true);
        StartCoroutine(SceneLoader());
    }
    // Start is called before the first frame update
    IEnumerator SceneLoader(){
        yield return new WaitForSeconds(2);
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
