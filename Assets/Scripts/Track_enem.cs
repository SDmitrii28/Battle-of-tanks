using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track_enem : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject track_left;
    public GameObject track_right;
    public GameObject track;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawn_track());
    }
    IEnumerator spawn_track()
    {
        while (true)
        {

            Vector3 Pose_left = track_left.transform.position;
            Quaternion pos_left = track_left.transform.rotation;
            Instantiate(track, Pose_left, pos_left);
            //right
            Vector3 Pose_right = track_right.transform.position;
            Quaternion pos_right = track_right.transform.rotation;
            Instantiate(track, Pose_right, pos_right);
            //Destroy(track, 1/5f);
            //Destroy(pul_right, 1);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
