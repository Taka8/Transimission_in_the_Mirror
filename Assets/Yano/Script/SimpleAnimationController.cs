using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAnimationController : MonoBehaviour {

    public enum Actions
    {
        Default = 0,
        Move = 1,
        Attack = 2,
        Die = 3,
        Damage = 4,
        Idle = 5,
    }

    SimpleAnimation sa;

	void Start () {
        sa = GetComponent<SimpleAnimation>();
	}

    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.A))
    //    {
    //        DoAction(Actions.Attack);
    //    }
    //}

    public void DoAction(Actions action)
    {
        sa.Stop();
        sa.CrossFade(action.ToString(), 0.2f);
    }
}
