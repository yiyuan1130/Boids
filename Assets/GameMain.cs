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
	
}
