using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject PacMan;
    private Tweener tweener;
    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PacMan.transform.position.x < 6f && PacMan.transform.position.y == -1f)
        {
            PacMan.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            tweener.AddTween(PacMan.transform, PacMan.transform.position, new Vector2(6f, -1f), 1f);
        }
        else if (PacMan.transform.position.x == 6f && PacMan.transform.position.y > -5f)
        {
            PacMan.transform.rotation = Quaternion.Euler(0f, 0f, -90f);
            tweener.AddTween(PacMan.transform, PacMan.transform.position, new Vector2(6f, -5f), 1f);
        }
        else if (PacMan.transform.position.x > 1f && PacMan.transform.position.y == -5f)
        {
            PacMan.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            tweener.AddTween(PacMan.transform, PacMan.transform.position, new Vector2(1f, -5f), 1f);
        }
        else if (PacMan.transform.position.x == 1f && PacMan.transform.position.y < -1f)
        {
            PacMan.transform.rotation = Quaternion.Euler(0f, 180f, 90f);
            tweener.AddTween(PacMan.transform, PacMan.transform.position, new Vector2(1f, -1f), 1f);
        }
    }
}
