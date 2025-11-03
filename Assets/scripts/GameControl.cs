using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private Transform[] pictures;
    [SerializeField]
    private GameObject wintText;

    public static bool youWin;

    void Start()
    {
        if (wintText != null)
        {
            wintText.SetActive(false);
        }
        youWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (pictures != null && pictures.Length >= 9 &&
            pictures[0] != null && pictures[1] != null &&
            pictures[2] != null && pictures[3] != null &&
            pictures[4] != null && pictures[5] != null &&
            pictures[6] != null && pictures[7] != null &&
            pictures[8] != null &&
            Mathf.Approximately(pictures[0].rotation.eulerAngles.z, 0) &&
            Mathf.Approximately(pictures[1].rotation.eulerAngles.z, 0) &&
            Mathf.Approximately(pictures[2].rotation.eulerAngles.z, 0) &&
            Mathf.Approximately(pictures[3].rotation.eulerAngles.z, 0) &&
            Mathf.Approximately(pictures[4].rotation.eulerAngles.z, 0) &&
            Mathf.Approximately(pictures[5].rotation.eulerAngles.z, 0) &&
            Mathf.Approximately(pictures[6].rotation.eulerAngles.z, 0) &&
            Mathf.Approximately(pictures[7].rotation.eulerAngles.z, 0) &&
            Mathf.Approximately(pictures[8].rotation.eulerAngles.z, 0))
        {
            youWin = true;
            if (wintText != null)
            {
                wintText.SetActive(true);
            }
        }
    }
}

