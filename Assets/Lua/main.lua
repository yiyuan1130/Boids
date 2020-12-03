print("lua main")

package.path = CS.UnityEngine.Application.dataPath .. "/Lua/?.lua"

Debug           = CS.UnityEngine.Debug

GameObject      = CS.UnityEngine.GameObject
Transform       = CS.UnityEngine.Transform
RectTransform   = CS.UnityEngine.RectTransform
Vector2         = CS.UnityEngine.Vector2
Vector3         = CS.UnityEngine.Vector3
Quaternion      = CS.UnityEngine.Quaternion
RigidBody       = CS.UnityEngine.RigidBody
Time            = CS.UnityEngine.Time
Ray             = CS.UnityEngine.Ray
Physics         = CS.UnityEngine.Physics
LayerMask       = CS.UnityEngine.LayerMask
RaycastHit      = CS.UnityEngine.RaycastHit
Color           = CS.UnityEngine.Color
Mathf           = CS.UnityEngine.Mathf

SceneManagement = CS.UnityEngine.SceneManagement
LoadSceneMode   = CS.UnityEngine.SceneManagement.LoadSceneMode
SceneManager    = CS.UnityEngine.SceneManagement.SceneManager

LuaBehaviour    = CS.LuaBehaviour

require("core/main")


-------------------------------------------------------

-- SceneManager.LoadScene("GameScene", LoadSceneMode.Single)

local Bird = require("game/Bird")
local birdsP = GameObject.Find("birds").transform
local birds = {}
for i = 0, birdsP.childCount - 1 do
    -- local go = GameObject.Find("bird" .. i)
    local go = birdsP:GetChild(i).gameObject
    go.transform.position = go.transform.position + Vector3.one * (math.random() * 2 - 1) * 3
    local birdIns = BehaviourUtil.AddBehaviour(go, Bird)
    table.insert(birds, birdIns)
end
for _, instances in pairs(birds) do
    instances.birds = birds
end

-- local BirdController = require("game/BirdController")



