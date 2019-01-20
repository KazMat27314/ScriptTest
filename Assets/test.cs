using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
	private int mp = 53;
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

	public void Magic(){
		if (mp >= 5) {
			mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp);
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
}

public class test : MonoBehaviour {



	// Use this for initialization
	void Start () {
		int[] array = {10,20,30,40,50};

		Debug.Log ("配列の順番通り");
		for (int i = 0; i < array.Length; i++) {
			Debug.Log(array[i]);
		}
		Debug.Log ("配列の逆順番");
		for (int i = array.Length - 1 ; i >= 0; i--) {
			Debug.Log(array[i]);
		}

		Boss boss = new Boss ();
		for (int x = 0; x < 11; x++) {
			boss.Magic ();
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
