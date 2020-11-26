/*
 * Tencent is pleased to support the open source community by making xLua available.
 * Copyright (C) 2016 THL A29 Limited, a Tencent company. All rights reserved.
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
 * http://opensource.org/licenses/MIT
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using XLua;
using System;

[System.Serializable]
public class Injection
{
    public string name;
    public GameObject value;
}

[LuaCallCSharp]
public class LuaBehaviour : MonoBehaviour
{
    public string luaClass;

    private Action<LuaTable> luaAwake;
    private Action<LuaTable> luaStart;
    private Action<LuaTable> luaUpdate;
    private Action<LuaTable> luaOnDestroy;

    private LuaTable luaScript;

    public void Init(LuaTable luaScript){
        this.luaScript = luaScript;
        luaClass = luaScript.Get<string>("_cls_name");
        // luaAwake = luaScript.Get<Action<LuaTable>>("Awake");
        luaScript.Get("Start", out luaStart);
        luaScript.Get("Update", out luaUpdate);
        luaScript.Get("OnDestroy", out luaOnDestroy);
    }
    void Awake()
    {
        if (luaAwake != null)
        {
            luaAwake(luaScript);
        }
    }

    void Start()
    {
        if (luaStart != null)
        {
            luaStart(luaScript);
        }
    }

    void Update()
    {
        if (luaUpdate != null)
        {
            luaUpdate(luaScript);
        }
    }

    void OnDestroy()
    {
        if (luaOnDestroy != null)
        {
            luaOnDestroy(luaScript);
        }
        luaOnDestroy = null;
        luaUpdate = null;
        luaStart = null;
    }
}