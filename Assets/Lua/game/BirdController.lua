local BirdController = class("BirdController")

function BirdController:ctor()
    self.birdList = {}
end

function BirdController:Start()
    self.birdsParent = GameObject.Find("birds").transform
    self.birdPrefab = GameObject.Find("bird1")
    self.birdPrefab:SetActive(false)
    self.birdIns = {}
end

function BirdController:Update()
    if Input.GetKey(KeyCode.Space) then
        self:createBird()
    end
end

function BirdController:createBird()
    local Bird = require("game/Bird")
    local birdObj = GameObject.Instantiate(self.birdPrefab)
    birdObj:SetActive(true)
    birdObj.transform:SetParent(self.birdsParent)
    birdObj.transform.localPosition = Vector3.zero
    local birdIns = BehaviourUtil.AddBehaviour(birdObj, Bird, self)
    table.insert(self.birdIns, birdIns)
end

function BirdController:OnDestroy()

end

return BirdController