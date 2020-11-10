/**

 Credits.cs

 This file deals with outputing "QUIT" to the console
 --
*/

using UnityEngine;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
