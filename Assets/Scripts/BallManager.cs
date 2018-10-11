using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // ボールが何かのコリジュンに衝突
    void OnCollisionEnter2D (Collision2D coll)
    {
        if (coll.gameObject.tag == "OutArea")
        {
            // 「アウトエリア」に衝突
            // ゲームマネージャーを習得
            GameObject gameManager = GameObject.Find("GameManager");
            // リトライ
            gameManager.GetComponent<GameManager>().PushRetryButton();
        }
    }
}
