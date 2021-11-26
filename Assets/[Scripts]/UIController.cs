using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UIController : MonoBehaviour
{
    [Header("OnScreen Controls")]
    public GameObject onscreenControls;

    [Header("Button Events")]
    public static bool isJumpButtonPressed;

    void Start()
    {
        switch (Application.platform)
        {
            case RuntimePlatform.Android:
            case RuntimePlatform.IPhonePlayer:
                onscreenControls.SetActive(true);
                break;
            case RuntimePlatform.WebGLPlayer:
            case RuntimePlatform.WindowsPlayer:
                onscreenControls.SetActive(false);
                break;
        }
    }

    void Update()
    {

    }

    public void OnJumpButton_Down()
    {
        Debug.Log("Jump Button Down");
        isJumpButtonPressed = true;
    }

    public void OnJumpButton_Up()
    {
        Debug.Log("Jump Button Up");
        isJumpButtonPressed = false;
    }
}
