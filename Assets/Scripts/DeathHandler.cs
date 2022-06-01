using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
   [SerializeField] Canvas gameOVerCanvas;
   private void Start(){
      gameOVerCanvas.enabled=false;
   }

   public void HandleDeath(){
      gameOVerCanvas.enabled = true;
      Time.timeScale = 0;
      Cursor.lockState = CursorLockMode.None;
      Cursor.visible = true;
   }
}
