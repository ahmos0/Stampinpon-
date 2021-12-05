using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class botankonnit : MonoBehaviour
{
    //public List<AudioClip> clips;   // AudioClip格納用List
    private AudioSource audioSource;// AudioSource格納用
    //private int audioIndex = -1;    // Listのインデックス用(インクリメントを考慮して-1指定)

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // 遅延実行処理により、音声再生開始
        // ※0秒後にPlaySoundメソッドを実行し、3秒間隔で繰り返しPlaySoundメソッドを呼ぶ
        InvokeRepeating("PlaySound", 0f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        // スペースキーが押されたら、音声停止(テスト用に実装)
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            StopSound();
        }
    }
    

    // 音声再生処理
    public void PlaySound() {

        // 再生中だった場合は音声停止
        if (audioSource.isPlaying) {
            audioSource.Pause();
        }

        // インデックスをインクリメント
        // ※インデックス値が配列の要素数を超えない様に調整する
        //audioIndex++;
        /*if (audioIndex > clips.Count-1) {
            audioIndex = 0;
        }*/

        // 音声ファイルを切り替えてから、再生を行う
        //audioSource.clip = clips[audioIndex];
        audioSource.Play();
    }

    // 音声停止処理
    // ※停止したいタイミングでこの処理を呼ぶ
    public void StopSound() {
        // 音声停止
        if (audioSource.isPlaying) {
            audioSource.Stop();
        }

        // 遅延実行停止
        //CancelInvoke();
    }
}
