using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailMenu : MonoBehaviour
{

    public GameObject FailedM ; 

    public Transform player;

    public float spawnDistance = 2 ;
    public float hauteur = 2 ;

    public TextMeshProUGUI txt;
    public PauseManager pauseManager;

    
    void Start()
    {
      FailedM.SetActive(true) ;  
      // FailedM.transform.LookAt(player.transform.position);
      // FailedM.transform.position = player.position + player.forward * spawnDistance + new Vector3(0, hauteur,0);
      // FailedM.transform.Rotate(0, 180, 0);
      FailedM.transform.position=player.position + new Vector3(player.forward.x,hauteur,player.forward.z).normalized*spawnDistance ;
      FailedM.transform.LookAt(new Vector3(2 * FailedM.transform.position.x - player.position.x, FailedM.transform.position.y, 2 * FailedM.transform.position.z - player.position.z));                   
            
      pauseManager.ModeMenu(true);
    }

    public void SetMessageCollisionRobot(){
      txt.text = "Accident...";
    } 
    public void SetMessageCollisionRobotEtPriorite(){
      txt.text = "Accident... Vous n'avez pas respecté la priorité à droite";
    } 
    public void SetMessageCollision(String name){
      txt.text = "Attention, vous avez touché "+ name;
    }
    public void SetMessageExitedRoad(){
      txt.text = "Attention, vous êtes sorti des limites du jeu. Veuillez relire la consigne du début";
    }
    public void SetMessagePriorite_ADroite(){
      txt.text = "Vous n'avez pas respecté la règle de la priorité à droite";
    }
    
    public void QuitterF(){
        SceneManager.LoadScene("debut"); 

    }
    public void Recommencer(){
             SceneManager.LoadScene("PrioritéV2"); 
   
    }
}
