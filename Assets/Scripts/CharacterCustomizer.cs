using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCustomizer : MonoBehaviour
{
    public GameObject[] hairs;
    public GameObject [] shirts;
    public GameObject [] pants;
    public Animator uiAnimator;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < hairs.Length; i++)
        {
            hairs[i].SetActive(false);
        }

        for (int i = 0; i < shirts.Length; i++)
        {
            shirts[i].SetActive(false);
        }

        for (int i = 0; i < pants.Length; i++)
        {
            pants[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hair(int hairNum)
    {
        for( int i=0; i<hairs.Length; i++)
        {
            hairs[i].SetActive(false);
        }

        hairs[hairNum].SetActive(true);
    }

    public void Shirt(int shirtNum)
    {
        for (int i = 0; i < shirts.Length; i++)
        {
            shirts[i].SetActive(false);
        }

        shirts[shirtNum].SetActive(true);
    }

    public void Pants(int pantNum)
    {
        for (int i = 0; i < pants.Length; i++)
        {
            pants[i].SetActive(false);
        }

        pants[pantNum].SetActive(true);
    }

    public void CloseWindow()
    {
        uiAnimator.SetTrigger("Close");
    }

    public void OpenWindow()
    {
        uiAnimator.SetTrigger("Open");
    }
}
