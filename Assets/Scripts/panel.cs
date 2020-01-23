using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel : MonoBehaviour {
    [SerializeField] GameObject[] panelList;
    string objName;
    // Use this for initialization

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit)) {
                objName = Hit.transform.name;
                Debug.Log(Hit.collider.gameObject.name);
                switch (objName) {
                    case "skinA":
                        OpenPanel(5);
                        break;
                    case "skinB":
                        OpenPanel(5);
                        break;
                    case "pelvisA":
                        OpenPanel(1);
                        break;
                    case "placentaA":
                        OpenPanel(2);
                        break;
                    case "placentaB":
                        OpenPanel(2);
                        break;
                    case "urinary":
                        OpenPanel(4);
                        break;
                    case "navel":
                        OpenPanel(3);
                        break;
                    case "fetus":
                        OpenPanel(0);
                        break;
                    default:
                        break;

                }

            }

        }
    }

   public void ResetPanels() {

        for (int i = 0; i < panelList.Length; i++) {

            if(panelList[i].activeSelf)
                panelList[i].SetActive(false);
        }
    }


    public void OpenPanel(int index) {

        ResetPanels();
        panelList[index].SetActive(true);

    }
}
