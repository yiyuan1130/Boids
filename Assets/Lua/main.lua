print("lua main")

package.path = CS.UnityEngine.Application.dataPath .. "/Lua/?.lua"

GameObject      = CS.UnityEngine.GameObject
Transform       = CS.UnityEngine.Transform
RectTransform   = CS.UnityEngine.RectTransform
Vector2         = CS.UnityEngine.Vector2
Vector3         = CS.UnityEngine.Vector3
Quaternion      = CS.UnityEngine.Quaternion
RigidBody       = CS.UnityEngine.RigidBody
Time            = CS.UnityEngine.Time

LuaBehaviour    = CS.LuaBehaviour

require("core/main")


-------------------------------------------------------

local Bird = require("game/Bird")
local go = GameObject.Find("bird1")
local birdIns = BehaviourUtil.AddBehaviour(go, Bird)


