using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Test : MonoBehaviour
{

    private Text txt;
	// Use this for initialization
	void Start ()
	{
	    txt = transform.Find("Text").GetComponent<Text>();
	    txt.text = "hello Mr.J";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
