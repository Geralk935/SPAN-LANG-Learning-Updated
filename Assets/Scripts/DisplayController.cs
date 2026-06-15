using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayController : MonoBehaviour
{
	private GameObject display;
    private AudioSource audioSource; 
    private AudioClip[] audioArray; 

	void Start()
    {
		display = GameObject.FindWithTag("Display");
		audioSource = display.GetComponent<AudioSource>();
        audioArray = display.GetComponent<AudioHolder>().array; 
		StartCoroutine(displayScript());
	}

	IEnumerator displayScript()
    {
		yield return new WaitForSecondsRealtime(10.0f); 
        int audioIndex; 

		for (int i = 0; i < 23; i+=2){
			display.transform.GetChild(i).gameObject.SetActive(true);
			display.transform.GetChild(i + 1).gameObject.SetActive(true);
			audioIndex = (int)i/2; 
			audioSource.PlayOneShot(audioArray[audioIndex]); 
			yield return new WaitForSecondsRealtime(3.0f); 
			audioSource.PlayOneShot(audioArray[audioIndex]); 
			yield return new WaitForSecondsRealtime(3.0f); 
			display.transform.GetChild(i).gameObject.SetActive(false);
			display.transform.GetChild(i + 1).gameObject.SetActive(false);
		}
		
		yield return new WaitForSecondsRealtime(5.0f);
		Application.Quit();
	}
}
