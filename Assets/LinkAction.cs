﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkAction : MonoBehaviour {

    public string URL;

	public void OpenURL()
    {
        Application.OpenURL(URL);
    }
}
