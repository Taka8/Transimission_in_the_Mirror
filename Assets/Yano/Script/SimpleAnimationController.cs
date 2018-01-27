using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAnimationController : MonoBehaviour {

    public enum Actions
    {
        move = 1,
        attack = 2,
        die = 3,
        damage = 4,
    }

    SimpleAnimation sa;

	void Start () {
        sa = GetComponent<SimpleAnimation>();
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            DoAction(Actions.attack);
        }
    }

    public void DoAction(Actions action)
    {
        sa.Stop();
        sa.CrossFade(action.ToString(), 0.2f);
    }
}
