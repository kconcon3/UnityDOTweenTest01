using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Test01 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 下記はどちらを使っても同じ
#if true
		gameObject.transform.DOMove(new Vector3(400.0f, 0.0f, 0.0f), 1.0f);
#else
		DOTween.To(
			() => gameObject.transform.position,	// getter
			x => transform.position = x,			// setter
			new Vector3(400.0f, 0.0f, 0.0f),		// to
			1.0f									// duration
		);
#endif
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
