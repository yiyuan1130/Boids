BehaviourUtil = class("BehaviourUtil")

BehaviourUtil.AddBehaviour = function(obj, luaCls, ...)
    local luaBehaviour = obj:AddComponent(typeof(LuaBehaviour))
    local clsIns = luaCls.new(...)
    clsIns.gameObject = obj
    luaBehaviour:Init(clsIns)
    return clsIns
end