using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int StageNo;             // ステージナンバー

    public bool isBallMoving;       // ボール移動中か否か

    public GameObject ballPrefab;   // ボールプレハブ
    public GameObject ball;         // ボールオブジェクト

    public GameObject goButton;     // ボタン：ゲーム開始
    public GameObject retryButton;  // ボタン：リトライ

	// Use this for initialization
	void Start () {
        retryButton.SetActive(false);   // リトライボタンを非表示
        isBallMoving = false;           // ボールは「移動中ではない」
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // GOボタンを押した
    public void PushGoButton()
    {
        // ボタンの重力を有効化
        Rigidbody2D rd = ball.GetComponent<Rigidbody2D>();
        rd.isKinematic = false;

        retryButton.SetActive(true);    // リトライボタンを表示
        goButton.SetActive(false);      // GOボタンを表示
        isBallMoving = true;            // ボールは「移動中」
    }
}
