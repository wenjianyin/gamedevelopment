using UnityEngine;
using System.Collections;

public class PauseObject : MonoBehaviour
{
    static PauseObject[] _pauseObjects;

    public static void Pause()
    {
        Time.timeScale = 0;

        _pauseObjects = FindObjectsOfType<PauseObject>();
        foreach (PauseObject pauseObject in _pauseObjects)
        {
            PauseObject.Pause();
        }
    }

    public static void Resume()
    {
        Time.timeScale = 1;

        if (null == _pauseObjects) return;

        foreach (PauseObject pauseObject in _pauseObjects)
        {
            if (pauseObject != null) PauseObject.Resume();
        }
    }
}