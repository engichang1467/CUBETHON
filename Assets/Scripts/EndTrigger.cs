/**

 EndTrigger.cs

 This file deals with making trigger when a level is complete
*/

using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
    }
}
