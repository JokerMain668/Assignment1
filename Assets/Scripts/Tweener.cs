using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    private Tween activeTween;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (activeTween == null)
        {
            return;
        }
        float distance = Vector2.Distance(activeTween.Target.position, activeTween.EndPos);
        if (distance > 0.1f)
        {
            float timeFraction = (Time.time - activeTween.StartTime) / activeTween.Duration;
            activeTween.Target.position = Vector3.Lerp(activeTween.StartPos, activeTween.EndPos, timeFraction);
        }
        if (distance <= 0.1f)
        {
            activeTween.Target.position = activeTween.EndPos;
            activeTween = null;
        }
    }
    public void AddTween(Transform targetObject, Vector2 startPos, Vector2 endPos, float duration)
    {
        if (activeTween == null)
        {
            
            activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
        }
    }
    public bool TweenExists(Transform target)
    {
        if (target.transform != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
