using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
public class GameMain : MonoBehaviour {

	void Awake(){
		LuaEnv env = new LuaEnv();
		string luaMainPath = Application.dataPath + "/Lua/main.lua";
		env.DoString(string.Format("dofile '{0}'", luaMainPath));
	}

	// void Update(){
	// 	// UnityEngine.SceneManagement.SceneManager.LoadScene("StartScene", UnityEngine.SceneManagement.LoadSceneMode.Single);
	// 	// Ray ray = new Ray();
	// 	// LayerMask
	// 	// if (Physics.Raycast(ray, out hit, 10));
	// 	Transform bird = GameObject.Find("bird1").transform; 
	// 	Transform eye = bird.Find("Bip001/Bip001 Pelvis/Bip001 Spine/Bip001 Neck/Bip001 Head/");
	// 	Ray ray = new Ray(eye.position, eye.position + bird.forward);
	// 	RaycastHit hit;
	// 	if (Physics.Raycast(ray, out hit, 10)){
	// 		Debug.Log("Hit ==> " + hit.point);
	// 	}
	// }
	
}
