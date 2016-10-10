using UnityEngine;
using System.Collections;

public class MoveAlong : MonoBehaviour {
    public Vector3 [] wayPoints;
    public float m_Speed;

    private Rigidbody m_rigidBody;
    private int m_CurrentWayPointIndex = 0;
    private GameObject m_gameScene;

	// Use this for initialization
	void Start () {
        m_rigidBody = GetComponent<Rigidbody>();
        m_gameScene = GameObject.Find("gameScene");

        for(int i = 0; i < wayPoints.Length; i++)
        {
            wayPoints[i].x = transform.position.x;
            wayPoints[i].y = transform.position.y;
            wayPoints[i].z = transform.position.z + wayPoints[i].z;
        }
	}
	void onEnable()
    {
        m_rigidBody.isKinematic = true;
    }
    // Update is called once per frame
    void Update()
    {
        float step = m_Speed * Time.deltaTime;
        if (m_CurrentWayPointIndex <= wayPoints.Length-1)
        {
            transform.position = Vector3.MoveTowards(transform.position, wayPoints[m_CurrentWayPointIndex], step);
            if (transform.position == wayPoints[m_CurrentWayPointIndex])
            {
                m_CurrentWayPointIndex++;
                if (m_gameScene){
                    GameScene gScript = m_gameScene.GetComponent<GameScene>();
                    gScript.ChangeToRandomColor();
                }
            }
        }
    }
}
