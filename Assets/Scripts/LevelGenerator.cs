using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject Sprite1;
    public GameObject Sprite2;
    public GameObject Sprite3;
    public GameObject Sprite4;
    public GameObject Sprite5;
    public GameObject Sprite6;
    public GameObject Sprite7;
    int[,] levelMap = {
                        {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
                        {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
                        {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
                        {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
                        {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
                        {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
                        {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
                        {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
                        {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
                        {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
                        {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
                        {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
                        {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
                        {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
                        {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
                    };

    // Start is called before the first frame update
    void Awake()
    {
        //Debug.Log(levelMap.GetLength(0) + levelMap.GetLength(1));
        for (int i = 0; i < levelMap.GetLength(0); i++)
        {
            for (int a = 0; a < levelMap.GetLength(1); a++)
            {
                //int target = levelMap[i, a];
                Quaternion Rotation = Quaternion.Euler(0f, 0f, 0f);
                switch (levelMap[i, a]) {
                    case 1:
                        if (a > 0)
                        {
                            if (levelMap[i, a - 1] == 2)
                            {
                                if (i == 0)
                                {
                                    Rotation = Quaternion.Euler(0f, 0f, 90f);
                                }
                                else if (i == levelMap.GetLength(0) - 1)
                                {
                                    Rotation = Quaternion.Euler(0f, 0f, 180f);
                                }
                                else
                                {
                                    if (levelMap[i - 1, a] == 2)
                                    {
                                        Rotation = Quaternion.Euler(0f, 0f, 180f);
                                    }
                                    else
                                    {
                                        Rotation = Quaternion.Euler(0f, 0f, -90f);
                                    }
                                }
                            }
                            else if (levelMap[i, a + 1] == 2)
                            {
                                if (a == 0)
                                {
                                    Rotation = Quaternion.Euler(0f, 0f, -90f);
                                }
                                else if (a == levelMap.GetLength(0) - 1)
                                {
                                    Rotation = Quaternion.Euler(0f, 0f, -180f);
                                }
                                else
                                {
                                    if (levelMap[i - 1, a] == 2)
                                    {
                                        Rotation = Quaternion.Euler(0f, 0f, -90f);
                                    }
                                    else
                                    {
                                        Rotation = Quaternion.Euler(0f, 0f, 0f);
                                    }
                                }
                            }
                        }
                        else if (i > 0 && a == 0)
                        {
                            if (levelMap[i - 1, a] == 2)
                            {
                                if (levelMap[i, a + 1] == 2)
                                {
                                    Rotation = Quaternion.Euler(0f, 0f, 90f);
                                }
                            }
                        }
                        Instantiate(Sprite1, new Vector2(a, -i), Rotation);
                        break;
                    case 2:
                        if (a > 0 && a < levelMap.GetLength(1) - 1)
                        {
                            if (levelMap[i, a - 1] == 2 || levelMap[i, a + 1] == 2)
                            {
                                Rotation = Quaternion.Euler(0f, 0f, 90f);
                            }
                        }
                        if (a == 0 && levelMap[i, a + 1] == 2)
                        {
                            Rotation = Quaternion.Euler(0f, 0f, 90f);
                        }
                        Instantiate(Sprite2, new Vector2(a, -i), Rotation);
                        break;
                    case 3:
                        if (i == 9 && a == 8)
                        {
                            Rotation = Quaternion.Euler(0f, 0f, 90f);
                        }
                        else if (i == 10 && a == 8)
                        {
                            Rotation = Quaternion.Euler(0f, 0f, 0f);
                        }
                        else if (i == 7 && a == 13)
                        {
                            Rotation = Quaternion.Euler(0f, 0f, -90f);
                        }
                        else if (i > 0)
                        {
                            if (levelMap[i - 1, a] == 4 || levelMap[i - 1, a] == 3)
                            {
                                if (a == 0)
                                {
                                    Rotation = Quaternion.Euler(0f, 0f, 90f);
                                }
                                else if (a == levelMap.GetLength(0) - 1)
                                {
                                    Rotation = Quaternion.Euler(0f, 0f, 180f);
                                }
                                else
                                {
                                    if (levelMap[i, a - 1] == 4 || levelMap[i, a - 1] == 3)
                                    {
                                        Rotation = Quaternion.Euler(0f, 0f, 180f);
                                    }
                                    else
                                    {
                                        Rotation = Quaternion.Euler(0f, 0f, 90f);
                                    }
                                }
                            }
                            else if (levelMap[i + 1, a] == 4 || levelMap[i + 1, a] == 3)
                            {
                                if (a == 0)
                                {
                                    Rotation = Quaternion.Euler(0f, 0f, -90f);
                                }
                                else if (a == levelMap.GetLength(0) - 1)
                                {
                                    Rotation = Quaternion.Euler(0f, 0f, -180f);
                                }
                                else
                                {
                                    if (levelMap[i, a - 1] == 4 || levelMap[i, a - 1] == 3)
                                    {
                                        Rotation = Quaternion.Euler(0f, 0f, -90f);
                                    }
                                    else
                                    {
                                        Rotation = Quaternion.Euler(0f, 0f, 0f);
                                    }
                                }
                            }
                        }
                        Instantiate(Sprite3, new Vector2(a, -i), Rotation);
                        break;
                    case 4:
                        if (a > 0)
                        {
                            if (a >= 7 && a <= 8)
                            {
                                if (levelMap[i - 1, a] == 4 || levelMap[i - 1, a] == 3)
                                {
                                    Rotation = Quaternion.Euler(0f, 0f, 0f);
                                }
                                else
                                {
                                    Rotation = Quaternion.Euler(0f, 0f, 90f);
                                }
                            }
                            else if ((a >= 1 && a <= 6) || (a >= 9 && a < levelMap.GetLength(1)))
                            {
                                if (levelMap[i, a - 1] == 4 || levelMap[i, a - 1] == 3)
                                {
                                    Rotation = Quaternion.Euler(0f, 0f, 90f);
                                }
                                else
                                {
                                    Rotation = Quaternion.Euler(0f, 0f, 0f);
                                }
                            }
                        }
                        Instantiate(Sprite4, new Vector2(a, -i), Rotation);
                        break;
                    case 5:
                        Instantiate(Sprite5, new Vector2(a, -i), Rotation);
                        break;
                    case 6:
                        Instantiate(Sprite6, new Vector2(a, -i), Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(Sprite7, new Vector2(a, -i), Quaternion.identity);
                        break;
                    default:
                        break;
                }
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
