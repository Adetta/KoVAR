using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Member : MonoBehaviour {

    public string Name;
    public Sprite Picture;

	// Use this for initialization
	void Start () {
        Image pictureChild = GetComponentInChildren<Image>();
        if (pictureChild != null && Picture != null)
        {
            pictureChild.sprite = Picture;
        }

        Text nameChild = GetComponentInChildren<Text>();
        if (nameChild != null && Name != null)
        {
            nameChild.text = Name;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
