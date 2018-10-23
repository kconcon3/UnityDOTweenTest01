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
			() => gameObject.transform.position,	// 何に
			(n) => transform.position = n,			// 何を
			new Vector3(400.0f, 0.0f, 0.0f),		// どこまで(最終的な値)
			1.0f									// 時間
		);
#endif
	}
}
