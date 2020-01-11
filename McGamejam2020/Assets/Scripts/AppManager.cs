using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AppManager
{
   private static GameManager gameInstance;

   public static void SetGameInstance(GameManager gameManager)
   {
      gameInstance = gameManager;
   }

   public static GameManager GetGameInstance()
   {
      return gameInstance;
   }
}
