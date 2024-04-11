using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ExRay : MonoBehaviour
{
    public Text UIText;
    public int Point;
    public float checkEndTime = 30.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        checkEndTime -= Time.deltaTime;

        if (checkEndTime <= 0)
        {
            PlayerPrefs.SetInt("Point",Point);
            SceneManager.LoadScene("ResultScene");
        }
        if (Input.GetMouseButtonDown(1))
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(cast, out hit))
            {
                Debug.Log(hit.collider.gameObject.name);
                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);

                if (hit.collider.gameObject.tag == "Target")
                {
                    Destroy(hit.collider.gameObject);
                    Point += 1;
                    if (Point >= 10) DochangeScene();
                }
            }
            else
            {
                Point = 0;
            }

            UIText.text = Point.ToString();
        }
    }

    void DochangeScene()
    {
        SceneManager.LoadScene("ResultScene");
    }
}
