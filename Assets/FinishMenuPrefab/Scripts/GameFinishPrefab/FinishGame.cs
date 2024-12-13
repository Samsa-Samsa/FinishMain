using System;

namespace FinishMenuPrefab.Scripts.GameFinishPrefab
{
    // Class that handles game finishing logic
    public abstract class FinishGame 
    {
        // Event to notify when the game is finished
        public static  Action OnGameFinish;
    }
}