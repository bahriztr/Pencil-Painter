using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FinishPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0f;
        UIManager.Instance.ShowLevelFinishMenu();        
        //STOP PLAYER MOVEMENT and PLAY FINISH SOUND
        DOTween.KillAll();
        GameMaker.Instance.isPlayerAlive = false;
        Player.Instance.isGameStarted = false;
        FindObjectOfType<AudioManager>().Play("FinishSound");        
    }
}
