﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void Start()
    {
        
    }
    private void OnPointerUpAsButton() {

	}
    public void Restart() {
        SceneManager.LoadScene("StartPage");
    }
	void OnPointerEnter() {
	}
	void OnPointerExit() {
		
	}
    void Update()
    {
        
    }
}
