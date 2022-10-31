using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LeaderBoard : MonoBehaviour
{
    public Transform recordContainer;
    public Transform recordTemplate;
    

    // Update is called once per frame
    void Update()
    {

    }

    void Start() {
      // recordContainer = transform.Find("score_container");
        //recordTemplate = recordContainer.Find("score_template");

        recordTemplate.gameObject.SetActive(false);

        float templateHeight = 35f;

        for(int i=0; i<10; i++)
        {
            Transform startTransform = Instantiate(recordTemplate, recordContainer);
            RectTransform startRectTransform = startTransform.GetComponent<RectTransform>();
            startRectTransform.anchoredPosition = new Vector2(0, -templateHeight * i);
            startTransform.gameObject.SetActive(true);

            int rank = i + 1;
            string rankString;

            switch (rank)
            {
                default:
                    rankString = rank + "TH"; break;

                case 1:
                    rankString = "1ST"; break;
                case 2:
                    rankString = "2ND"; break;

                case 3:
                    rankString = "3RD"; break;
                case 4:
                    rankString = "4TH"; break;




            }


            startTransform.Find("pos")?.GetComponent<TextMeshPro>().SetText(rankString);

            int score = 100 - i * 10;
            startTransform.Find("user")?.GetComponent<TextMeshPro>().SetText("AAA");

            startTransform.Find("score")?.GetComponent<TextMeshPro>().SetText(score.ToString());

            int levelsReached = i + 1;
            startTransform.Find("levels_reached")?.GetComponent<TextMeshPro>().SetText(levelsReached.ToString());

        }

    }

}
