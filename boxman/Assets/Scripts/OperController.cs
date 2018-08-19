using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OperController : MonoBehaviour {

    Button mLeftBtn;
    Button mTopBtn;
    Button mRightBtn;
    Button mBottomBtn;
    Button mPreBtn;
    Button mRestartBtn;

	// Use this for initialization
	void Start () {
        mLeftBtn = transform.Find("left").GetComponent<Button>();

        mLeftBtn.onClick.AddListener(OnLeftClick);
	}
	
    void OnLeftClick(){
        Debug.Log("left click ---");
    }


}
